using Application.DTOS.LibroDTO;
using MediatR;

namespace Application.Infraestructure.Queries
{
    public record GetLibroByGeneroQuery(string Genero) : IRequest<GetLibroDTO>;
  
}
