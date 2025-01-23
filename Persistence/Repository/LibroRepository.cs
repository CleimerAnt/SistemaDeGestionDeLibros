using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Entities;
using Persistence.Repository.IRepository;

namespace Persistence.Repository
{
    public class LibroRepository : ILibroRepository
    {
        private readonly ApplicationContext _context;
        public LibroRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Libros> AddLibroAsync(Libros libro)
        {
            await _context.Set<Libros>().AddAsync(libro);
            await _context.SaveChangesAsync();
            return libro;
        }
        public async Task UpdateLibroAsync(Libros libro, int Id)
        {
            Libros entry = await _context.Set<Libros>().FindAsync(Id);
            _context.Entry(entry).CurrentValues.SetValues(libro);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteLibroAsync(Libros libro)
        {
            _context.Set<Libros>().Remove(libro);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Libros>> GetAllLibrosAsync() => await _context.Set<Libros>().ToListAsync();
        public async Task<Libros> GetLibroByIdAsync(int Id) => await _context.Set<Libros>().FindAsync(Id);
        public async Task<Libros> GetLibroByGeneroAsync(string Genero) => await _context.Set<Libros>().FirstOrDefaultAsync(l => l.Genero == Genero);

    }

}
