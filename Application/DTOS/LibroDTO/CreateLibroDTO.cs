using System.ComponentModel.DataAnnotations;

namespace Application.DTOS.LibroDTO
{
    public class CreateLibroDTO
    {
        [Required(ErrorMessage = "El titulo del libro es requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El Autor del libro es requerido")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El Genero del libro es requerido")]
        public string Genero { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "El Precio debe ser mayor que 0")]
        public decimal Precio { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}
