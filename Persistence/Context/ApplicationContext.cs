using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Libros> Libros { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libros>().ToTable("Libros");
            modelBuilder.Entity<Libros>().HasKey(l => l.Id);
            modelBuilder.Entity<Libros>().Property(l => l.Titulo).IsRequired();
            modelBuilder.Entity<Libros>().Property(l => l.Autor).IsRequired();
            modelBuilder.Entity<Libros>().Property(l => l.Genero).IsRequired();
        }
    }
}
