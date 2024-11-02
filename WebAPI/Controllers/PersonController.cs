using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Contracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var model = await _personService.GetPersonAsync(id);

            return Ok(model);
        }

        [HttpPost("")]
        public async Task<IActionResult> PostPerson([FromBody] Person model)
        {
            model = await _personService.CreatePersonAsync(model);

            return Ok(model);
        }

        [HttpPut("")]
        public async Task<IActionResult> PutPerson([FromBody] Person model)
        {
            model = await _personService.UpdatePersonAsync(model);

            return Ok(model);
        }

        [HttpDelete("")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _personService.DeletePersonAsync(id);

            return Ok();
        }
    }
}
