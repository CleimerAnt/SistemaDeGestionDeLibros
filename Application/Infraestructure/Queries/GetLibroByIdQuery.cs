using Application.DTOS.LibroDTO;
using MediatR;

namespace Application.Infraestructure.Queries
{
    public record GetLibroByIdQuery(int Id) : IRequest<GetLibroDTO>;
   
}
