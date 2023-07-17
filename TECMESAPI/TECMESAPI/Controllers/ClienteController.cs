using Microsoft.AspNetCore.Mvc;
using TECMESAPI.API.Controllers;
using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : BaseController<ClienteEntity, ClienteDTO>
    {
        private readonly IClienteApplicationService _service;

        public ClienteController(IClienteApplicationService service): base(service) 
        {
            _service = service;
        }
    }
}
