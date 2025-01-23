
using Application.DTOS.LibroDTO;
using Application.Infraestructure.Commands;
using AutoMapper;
using MediatR;
using Persistence.Entities;
using Persistence.Repository.IRepository;

namespace Application.Handlers
{
    public class UpdateLibroHandler : IRequestHandler<UpdateLibroCommand, LibroDTO>
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;
        public UpdateLibroHandler(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository; 
            _mapper = mapper;
        }
        public async Task<LibroDTO> Handle(UpdateLibroCommand request, CancellationToken cancellationToken)
        {
            var libro = _mapper.Map<Libros>(request);
            await _libroRepository.UpdateLibroAsync(libro, libro.Id);

            LibroDTO libroDTO = _mapper.Map<LibroDTO>(libro);
            return libroDTO;
        }
    }
}
