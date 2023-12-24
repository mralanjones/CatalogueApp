using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.GenreService;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var model = await _genreService.GetGenreAsync(id);

            return Ok(model);
        }

        [HttpPost("")]
        public async Task<IActionResult> PostMovie([FromBody] Genre model)
        {
            model = await _genreService.CreateGenreAsync(model);
            return Ok(model);
        }

        [HttpPut("")]
        public async Task<IActionResult> PutMovie([FromBody] Genre model)
        {
            model = await _genreService.UpdateGenreAsync(model);

            return Ok(model);
        }

        [HttpDelete("")]
        public async Task<IActionResult> DeleteAsync(int movieId)
        {
            var model = await _genreService.DeleteGenreAsync(movieId);

            return Ok(model);
        }
    }
}
