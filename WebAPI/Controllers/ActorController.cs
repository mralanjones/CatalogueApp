using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Contracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var model = await _actorService.GetActorAsync(id);

            return Ok(model);
        }

        [HttpPost("")]
        public async Task<IActionResult> PostActor([FromBody] Actor model)
        {
            model = await _actorService.CreateActorAsync(model);

            return Ok(model);
        }

        [HttpPut("")]
        public async Task<IActionResult> PutActor([FromBody] Actor model)
        {
            model = await _actorService.UpdateActorAsync(model);

            return Ok(model);
        }

        [HttpDelete("")]
        public async Task<IActionResult> DeleteAsync(int movieId)
        {
            await _actorService.DeleteActorAsync(movieId);

            return Ok();
        }
    }
}
