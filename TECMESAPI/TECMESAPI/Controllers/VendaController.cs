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
    public class VendaController : BaseController<VendaEntity, VendaDTO>
    {
        private readonly IVendaApplicationService _service;

        public VendaController(IVendaApplicationService service)
            : base(service)
        {
            _service = service;
        }

        // PUT api/<BaseController>/5
        [HttpPut("autorizar/{id}")]
        public async Task<IActionResult> PutAsync(long id)
        {
            try
            {
                await _service.Autorizar(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);


            }
        }
    }
}
