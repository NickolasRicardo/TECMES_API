using AutoMapper;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Application.Services.Services
{
    public class ProducaoApplicationService
        : ApplicationServiceBase<ProducaoEntity, ProducaoDTO>,
            IProducaoApplicationService
    {
        private readonly IProducaoService _service;
        private readonly IMapper _mapper;

        public ProducaoApplicationService(IProducaoService service, IMapper mapper)
            : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
