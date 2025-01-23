using MediatR; 

namespace Application.Infraestructure.Commands
{
    public record DeleteLibroCommand(int Id) : IRequest<bool>;
    
}
