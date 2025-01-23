
namespace Application.DTOS.LibroDTO
{
    public class LibroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaPublicacion { get; set; }

    }
}
