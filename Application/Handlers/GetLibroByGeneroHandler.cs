
using Application.DTOS.LibroDTO;
using Application.Infraestructure.Queries;
using AutoMapper;
using MediatR;
using Persistence.Repository.IRepository;

namespace Application.Handlers
{
    public class GetLibroByGeneroHandler : IRequestHandler<GetLibroByGeneroQuery, GetLibroDTO>
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;
        public GetLibroByGeneroHandler(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository; 
            _mapper = mapper;
        }
        public async Task<GetLibroDTO> Handle(GetLibroByGeneroQuery request, CancellationToken cancellationToken)
        {
            var libro = await _libroRepository.GetLibroByGeneroAsync(request.Genero);
            if (libro == null) return null;
            
            GetLibroDTO getLibroDTO = _mapper.Map<GetLibroDTO>(libro);  
            return getLibroDTO;
        }
    }
}
