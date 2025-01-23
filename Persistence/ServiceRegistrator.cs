using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repository;
using Persistence.Repository.IRepository;

namespace Persistence
{
    public static class ServiceRegistrator
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region AddDbContext
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("conexion"),
                    m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName));
            });
            #endregion

            services.AddScoped<ILibroRepository, LibroRepository>();
        }
    }
}
