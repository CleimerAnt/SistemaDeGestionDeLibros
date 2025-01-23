using Application.DTOS.LibroDTO;
using Application.Infraestructure.Commands;
using AutoMapper;
using MediatR;
using Persistence.Entities;
using Persistence.Repository.IRepository;

namespace Application.Handlers
{
    public class CreateLibroHandler : 
        IRequestHandler<CreateLibroCommand, CreateLibroDTO>  
    {   
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;
        public CreateLibroHandler(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository;
            _mapper = mapper;
        }
        public async Task<CreateLibroDTO> Handle(CreateLibroCommand request, CancellationToken cancellationToken)
        {

            var libro = _mapper.Map<Libros>(request);
            await _libroRepository.AddLibroAsync(libro);

            CreateLibroDTO createLibroDTO = _mapper.Map<CreateLibroDTO>(libro);

            return createLibroDTO;
        }
    }
}
