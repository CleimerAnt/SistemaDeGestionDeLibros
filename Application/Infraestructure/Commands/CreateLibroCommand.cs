using Application.DTOS.LibroDTO;
using MediatR;

namespace Application.Infraestructure.Commands
{
    public record CreateLibroCommand(string Titulo, string Autor, string Genero, decimal Precio) :
        IRequest<CreateLibroDTO>;
}
