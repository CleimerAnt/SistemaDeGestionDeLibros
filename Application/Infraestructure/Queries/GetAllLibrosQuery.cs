using Application.DTOS.LibroDTO;
using MediatR;

namespace Application.Infraestructure.Queries
{
    public record GetAllLibrosQuery : IRequest<IEnumerable<GetLibroDTO>>; 
   
}
