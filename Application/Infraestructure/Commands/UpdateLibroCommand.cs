using Application.DTOS.LibroDTO;
using MediatR;

namespace Application.Infraestructure.Commands
{
    public record UpdateLibroCommand(int Id, string Titulo, string Autor, string Genero, decimal Precio, DateTime FechaPublicacion) 
        : IRequest<LibroDTO>;
  
}
