using AutoMapper;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Application.Services.Services
{
    public class ClienteApplicationService
        : ApplicationServiceBase<ClienteEntity, ClienteDTO>,
            IClienteApplicationService
    {
        private readonly IClienteService _service;
        private readonly IMapper _mapper;

        public ClienteApplicationService(IClienteService service, IMapper mapper)
            : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
