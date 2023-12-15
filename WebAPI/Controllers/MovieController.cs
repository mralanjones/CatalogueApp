using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
            {
                new Movie
                {
                    MovieId = 1,
                    Name = "The Matrix",
                    Year = 1999
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Goodfellas",
                    Year = 1999
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Gladiator",
                    Year = 2000
                }
            };

        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetAllMovies()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieById(int id)
        {
            return Ok(movies.Find(x => x.MovieId == id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Movie>>> AddMovie(Movie movie)
        {
            movies.Add(movie);

            return Ok(movies);
        }

        [HttpPut]
        public async Task<ActionResult<List<Movie>>> UpdateMovie(int movieId, Movie request)
        {
            var movie = movies.Find(x => x.MovieId == movieId);

            if (movie == null) {
                return NotFound("Movie not found.");
            }
            movie.Name = request.Name;
            movie.Year = request.Year;
            movie.MovieGenres = request.MovieGenres;

            return Ok(movies);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Movie>>> DeleteMovie(Movie request)
        {
            var movie = movies.Find(x => x.MovieId == request.MovieId);

            if (movie == null)
            {
                return NotFound("Movie not found.");
            }
            
            movies.Remove(movie);

            return Ok(movies);
        }
    }
}
