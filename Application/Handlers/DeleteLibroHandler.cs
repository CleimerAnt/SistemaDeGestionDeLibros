

using Application.Infraestructure.Commands;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Persistence.Repository.IRepository;

namespace Application.Handlers
{
    public class DeleteLibroHandler : IRequestHandler<DeleteLibroCommand, bool>
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;
        public DeleteLibroHandler(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository;
            _mapper = mapper;   
        }
        public async Task<bool> Handle(DeleteLibroCommand request, CancellationToken cancellationToken)
        {
            var libro = await _libroRepository.GetLibroByIdAsync(request.Id);

            if (libro == null) {
                return false;
            }

            await _libroRepository.DeleteLibroAsync(libro);
            return true;
        }
    }
}
