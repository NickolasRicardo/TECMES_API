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

            CreateMap<MaquinaEntity, MaquinaDTO>().ReverseMap();
            CreateMap<PagedModel<MaquinaEntity>, PagedModel<MaquinaDTO>>().ReverseMap();

            CreateMap<OrdemProducaoEntity, OrdemProducaoDTO>().ReverseMap();
            CreateMap<PagedModel<OrdemProducaoEntity>, PagedModel<OrdemProducaoDTO>>().ReverseMap();

            CreateMap<ProducaoEntity, ProducaoDTO>().ReverseMap();
            CreateMap<PagedModel<ProducaoEntity>, PagedModel<ProducaoDTO>>().ReverseMap();

            CreateMap<ProdutoEntity, ProdutoDTO>().ReverseMap();
            CreateMap<PagedModel<ProdutoEntity>, PagedModel<ProdutoDTO>>().ReverseMap();

            CreateMap<VendaEntity, VendaDTO>().ReverseMap();
            CreateMap<PagedModel<VendaEntity>, PagedModel<VendaDTO>>().ReverseMap();
        }
    }
}
