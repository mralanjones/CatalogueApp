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

        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetAllMovies()
        {
            return await _movieService.GetAllMovies();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieById(int id)
        {
            var result = await _movieService.GetMovieById(id);

            if (result == null)
            {
                return NotFound("Movie not found.");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> AddMovie(Movie movie)
        {
            return await _movieService.AddMovie(movie);
        }

        [HttpPut]
        public async Task<ActionResult<Movie>> UpdateMovie(int movieId, Movie request)
        {
            var result = await _movieService.UpdateMovie(movieId, request);

            if (result == null)
            {
                return NotFound("Movie not found. Could not update.");
            }

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> DeleteMovie(int movieId)
        {
            var result = await _movieService.DeleteMovie(movieId);

            if (result == 0)
            {
                return NotFound("Movie not found. Could not delete.");
            }

            return Ok(result);
        }
    }
}
