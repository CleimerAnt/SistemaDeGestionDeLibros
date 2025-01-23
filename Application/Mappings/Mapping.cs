using Application.DTOS.LibroDTO;
using Application.Infraestructure.Commands;
using AutoMapper;
using Persistence.Entities;

namespace Application.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<GetLibroDTO, Libros>().ReverseMap();
            CreateMap<CreateLibroDTO, Libros>().ReverseMap();
            CreateMap<LibroDTO, Libros>().ReverseMap();
            CreateMap<CreateLibroCommand,Libros>().ReverseMap();
            CreateMap<UpdateLibroCommand, Libros>().ReverseMap();
        }
    }
}
