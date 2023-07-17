using AutoMapper;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Application.Services.Services
{
    public class ProdutoApplicationService
        : ApplicationServiceBase<ProdutoEntity, ProdutoDTO>,
            IProdutoApplicationService
    {
        private readonly IProdutoService _service;
        private readonly IMapper _mapper;

        public ProdutoApplicationService(IProdutoService service, IMapper mapper)
            : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
