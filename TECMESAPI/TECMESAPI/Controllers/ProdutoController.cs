using Microsoft.AspNetCore.Mvc;
using TECMESAPI.API.Controllers;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : BaseController<ProdutoEntity, ProdutoDTO>
    {
        private readonly IProdutoApplicationService _service;

        public ProdutoController(IProdutoApplicationService service)
            : base(service)
        {
            _service = service;
        }
    }
}
