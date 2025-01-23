
using Application.DTOS.LibroDTO;
using Application.Infraestructure.Queries;
using AutoMapper;
using MediatR;
using Persistence.Repository.IRepository;

namespace Application.Handlers
{
    public class GetLibroByIdHandler : IRequestHandler<GetLibroByIdQuery, GetLibroDTO>
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;
        public GetLibroByIdHandler(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository;
            _mapper = mapper;
        }
        public async Task<GetLibroDTO> Handle(GetLibroByIdQuery request, CancellationToken cancellationToken)
        {
            var libro = await _libroRepository.GetLibroByIdAsync(request.Id);
            if (libro == null) return null;

            GetLibroDTO getLibroDTO = _mapper.Map<GetLibroDTO>(libro);
            return getLibroDTO;
        }
    }
}
