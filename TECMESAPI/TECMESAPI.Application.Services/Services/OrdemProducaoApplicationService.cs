using AutoMapper;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Application.Services.Services
{
    public class OrdemProducaoApplicationService
        : ApplicationServiceBase<OrdemProducaoEntity, OrdemProducaoDTO>,
            IOrdemProducaoApplicationService
    {
        private readonly IOrdemProducaoService _service;
        private readonly IMapper _mapper;

        public OrdemProducaoApplicationService(IOrdemProducaoService service, IMapper mapper)
            : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
