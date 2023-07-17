using TECMESAPI.Application.DTO;
using TECMESAPI.Application.Interfaces.Services;
using TECMESAPI.CrossCutting.Conditions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TECMESAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<TEntity, TDto> : ControllerBase where TEntity : class where TDto : DTOBase
    {
        private readonly IApplicationServiceBase<TEntity, TDto> _service;

        public BaseController(IApplicationServiceBase<TEntity, TDto> service)
        {
            _service = service;
        }

        // GET: api/<BaseController>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] QueryParam param)
        {
            try
            {
                var obj = await _service.GetAll(param);


                return Ok(obj);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = $"Ocorreu algum erro interno na aplicação: {ex.Message}" });
            }
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var obj = await _service.GetById(id);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = $"Ocorreu algum erro interno na aplicação: {ex.Message}" });
            }
        }

        // POST api/<BaseController>
        [HttpPost]
        public async Task Post(TDto value)
        {
            await _service.Add(value);
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        virtual public async Task PutAsync(long id, [FromBody] TDto value)
        {
            value.Id = id;
            await _service.Update(value);
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(long id)
        {
            await _service.Delete(id);
        }

       
    }
}
