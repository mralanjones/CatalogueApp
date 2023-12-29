using WebAPI.Services.Contracts;

namespace WebAPI.Services
{
    public class GenreService : IGenreService
    {
        public Task<Genre> CreateGenreAsync(Genre model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteGenreAsync(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Genre>> FilterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Genre> GetGenreAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> UpdateGenreAsync(Genre model)
        {
            throw new NotImplementedException();
        }
    }
}
