namespace WebAPI.Services.MovieService
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMovies();
        Task<Movie?> GetMovieById(int id);
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> UpdateMovie(int movieId, Movie request);
        Task<int> DeleteMovie(int movieId);
    }
}
