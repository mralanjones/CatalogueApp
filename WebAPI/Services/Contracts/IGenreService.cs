namespace WebAPI.Services.Contracts
{
    public interface IGenreService
    {
        Task<Genre> GetGenreAsync(int genreId);
        Task<Genre> CreateGenreAsync(Genre model);
        Task<Genre> UpdateGenreAsync(Genre model);
        Task DeleteGenreAsync(int genreId);
        Task<IEnumerable<Genre>> FilterAsync();
    }
}
