using Microsoft.AspNetCore.Mvc;
using TECMESAPI.API.Controllers;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaquinaController : BaseController<MaquinaEntity, MaquinaDTO>
    {
        private readonly IMaquinaApplicationService _service;

        public MaquinaController(IMaquinaApplicationService service)
            : base(service)
        {
            _service = service;
        }
    }
}
