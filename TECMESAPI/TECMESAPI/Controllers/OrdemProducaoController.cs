using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TECMESAPI.API.Controllers;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class OrdemProducaoController : BaseController<OrdemProducaoEntity, OrdemProducaoDTO>
    {
        private readonly IOrdemProducaoApplicationService _service;

        public OrdemProducaoController(IOrdemProducaoApplicationService service)
            : base(service)
        {
            _service = service;
        }
    }
}
