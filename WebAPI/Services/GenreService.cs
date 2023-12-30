using WebAPI.Models;
using WebAPI.Services.Contracts;

namespace WebAPI.Services
{
    public class GenreService : IGenreService
    {
        private readonly DataContext _context;

        public GenreService(DataContext context)
        {
            _context = context;
        }

        public async Task<Genre> CreateGenreAsync(Genre model)
        {
            _context.Genres.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task DeleteGenreAsync(int genreId)
        {
            var genre = await _context.Genres.FindAsync(genreId);

            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Genre>> FilterAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Genre> GetGenreAsync(int genreId)
        {
            var genre = await _context.Genres.FindAsync(genreId);

            return genre;
        }

        public async Task<Genre> UpdateGenreAsync(Genre model)
        {
            var genre = await _context.Genres.FindAsync(model.GenreId);

            genre.Name = model.Name;
            await _context.SaveChangesAsync();

            return genre;
        }
    }
}
