namespace WebAPI.Services.GenreService
{
    public interface IGenreService
    {
        Task<Genre> GetGenreAsync(int id);
        Task<Genre> CreateGenreAsync(Genre model);
        Task<Genre> UpdateGenreAsync(Genre model);
        Task<int> DeleteGenreAsync(int movieId);
        Task<IEnumerable<Genre>> FilterAsync();
    }
}
