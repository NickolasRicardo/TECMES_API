using AutoMapper;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Application.Services.Services
{
    public class MaquinaApplicationService
        : ApplicationServiceBase<MaquinaEntity, MaquinaDTO>,
            IMaquinaApplicationService
    {
        private readonly IMaquinaService _service;
        private readonly IMapper _mapper;

        public MaquinaApplicationService(IMaquinaService service, IMapper mapper)
            : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
