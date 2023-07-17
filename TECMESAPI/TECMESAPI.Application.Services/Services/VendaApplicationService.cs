using AutoMapper;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Application.Services.Services
{
    public class VendaApplicationService
        : ApplicationServiceBase<VendaEntity, VendaDTO>,
            IVendaApplicationService
    {
        private readonly IVendaService _service;
        private readonly IMapper _mapper;

        public VendaApplicationService(IVendaService service, IMapper mapper)
            : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
