using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.MovieService;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService) {
            _movieService = movieService;
        }

        //[HttpGet("filter")]
        //public async Task<IActionResult> FilterAsync([FromQuery] PagedCollectionFilter filter)
        //{
        //    var model = await _movieService.FilterMoviesAsync(filter);

        //    return Ok(model);
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var model = await _movieService.GetMovieAsync(id);

            return Ok(model);
        }

        [HttpPost("")]
        public async Task<IActionResult> PostMovie([FromBody]Movie model)
        {
            model = await _movieService.CreateMovieAsync(model);
            return Ok(model);
        }

        [HttpPut("")]
        public async Task<IActionResult> PutMovie([FromBody]Movie model)
        {
            model = await _movieService.UpdateMovieAsync(model);

            return Ok(model);
        }

        [HttpDelete("")]
        public async Task<IActionResult> DeleteAsync(int movieId)
        {
            var model = await _movieService.DeleteMovie(movieId);

            return Ok(model);
        }
    }
}
