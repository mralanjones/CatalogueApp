namespace WebAPI.Services.MovieService
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie? GetMovieById(int id);
        List<Movie> AddMovie(Movie movie);
        List<Movie>? UpdateMovie(int movieId, Movie request);
        List<Movie>? DeleteMovie(int movieId);
    }
}
