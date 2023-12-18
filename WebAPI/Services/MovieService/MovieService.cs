namespace WebAPI.Services.MovieService
{
    public class MovieService : IMovieService
    {
        private readonly DataContext _context;

        public MovieService(DataContext context)
        {
            _context = context;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        public async Task<int> DeleteMovie(int movieId)
        {
            var movie = await _context.Movies.FindAsync(movieId);

            if (movie == null)
            {
                return 0;
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return movieId;
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            var moviesTest = await _context.Movies.ToListAsync();
            return moviesTest;
        }

        public async Task<Movie?> GetMovieById(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
                return null;

            return movie;
        }

        public async Task<Movie> UpdateMovie(int movieId, Movie request)
        {
            var movie = await _context.Movies.FindAsync(movieId);

            if (movie == null)
            {
                return null;
            }
            movie.Name = request.Name;
            movie.Year = request.Year;
            //movie.MovieGenres = request.MovieGenres;

            await _context.SaveChangesAsync();

            return movie;
        }
    }
}
