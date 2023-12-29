using WebAPI.Services.Contracts;

namespace WebAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly DataContext _context;

        public MovieService(DataContext context)
        {
            _context = context;
        }

        public async Task<Movie> CreateMovieAsync(Movie model)
        {
            _context.Movies.Add(model);
            await _context.SaveChangesAsync();

            return model;
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

        // TODO: change to filter rather than get all.
        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            var moviesTest = await _context.Movies.ToListAsync();
            return moviesTest;
        }

        public async Task<Movie> GetMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            return movie;
        }

        public async Task<Movie> UpdateMovieAsync(Movie model)
        {
            var movie = await _context.Movies.FindAsync(model.MovieId);

            movie.Name = model.Name;
            movie.Year = model.Year;
            //movie.MovieGenres = request.MovieGenres;

            await _context.SaveChangesAsync();

            return movie;
        }
    }
}
