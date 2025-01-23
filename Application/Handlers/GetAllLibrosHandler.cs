using Application.DTOS.LibroDTO;
using Application.Infraestructure.Queries;
using AutoMapper;
using MediatR;
using Persistence.Repository.IRepository;

namespace Application.Handlers
{
    public class GetAllLibrosHandler : IRequestHandler<GetAllLibrosQuery, IEnumerable<GetLibroDTO>>
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;
        public GetAllLibrosHandler(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository;
            _mapper = mapper;   
        }
        public async Task<IEnumerable<GetLibroDTO>> Handle(GetAllLibrosQuery request, CancellationToken cancellationToken)
        {
            var libros = await _libroRepository.GetAllLibrosAsync();
            return _mapper.Map<IEnumerable<GetLibroDTO>>(libros);   
        }
    }
}
