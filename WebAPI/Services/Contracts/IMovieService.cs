namespace WebAPI.Services.Contracts
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> GetMovieAsync(int id);
        Task<Movie> CreateMovieAsync(Movie model);
        Task<Movie> UpdateMovieAsync(Movie model);
        Task<int> DeleteMovie(int movieId);
    }
}
