using Microsoft.AspNetCore.Mvc;
using TECMESAPI.API.Controllers;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProducaoController : BaseController<ProducaoEntity, ProducaoDTO>
    {
        private readonly IProducaoApplicationService _service;

        public ProducaoController(IProducaoApplicationService service)
            : base(service)
        {
            _service = service;
        }
    }
}
