using Persistence.Entities;

namespace Persistence.Repository.IRepository
{
    public interface ILibroRepository
    {
        Task<Libros> AddLibroAsync(Libros libro);
        Task DeleteLibroAsync(Libros libro);
        Task<IEnumerable<Libros>> GetAllLibrosAsync();
        Task<Libros> GetLibroByIdAsync(int Id);
        Task<Libros> GetLibroByGeneroAsync(string Genero);
        Task UpdateLibroAsync(Libros libro, int Id);
    }
}