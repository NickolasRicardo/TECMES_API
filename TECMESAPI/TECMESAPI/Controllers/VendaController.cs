using Microsoft.AspNetCore.Mvc;
using TECMESAPI.API.Controllers;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController : BaseController<VendaEntity, VendaDTO>
    {
        private readonly IVendaApplicationService _service;

        public VendaController(IVendaApplicationService service)
            : base(service)
        {
            _service = service;
        }
    }
}
