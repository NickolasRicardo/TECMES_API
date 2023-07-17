using AutoMapper;
using TECMESAPI.Application.DTO;
using TECMESAPI.CrossCutting.Pagination;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Application.Mapper
{
    public class ConfigurationMapping : Profile
    {
        public ConfigurationMapping()
        {
            CreateMap<ClienteEntity, ClienteDTO>().ReverseMap();
            CreateMap<PagedModel<ClienteEntity>, PagedModel<ClienteDTO>>().ReverseMap();
        }
    }
}
