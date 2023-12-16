namespace WebAPI.Services.MovieService
{
    public class MovieService : IMovieService
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

        public List<Movie> AddMovie(Movie movie)
        {
            movies.Add(movie);

            return movies;
        }

        public List<Movie> DeleteMovie(int movieId)
        {
            var movie = movies.Find(x => x.MovieId == movieId);

            if (movie == null)
            {
                return null;
            }

            movies.Remove(movie);

            return movies;
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie? GetMovieById(int id)
        {
            return movies.Find(x => x.MovieId == id);
        }

        public List<Movie>? UpdateMovie(int movieId, Movie request)
        {
            var movie = movies.Find(x => x.MovieId == movieId);

            if (movie == null)
            {
                return null;
            }
            movie.Name = request.Name;
            movie.Year = request.Year;
            //movie.MovieGenres = request.MovieGenres;

            return movies;
        }
    }
}
