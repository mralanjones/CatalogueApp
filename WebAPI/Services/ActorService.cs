using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Contracts;

namespace WebAPI.Services
{
    public class ActorService : IActorService
    {
        private readonly DataContext _context;

        public ActorService(DataContext context)
        {
            _context = context;
        }

        public async Task<Actor> CreateActorAsync(Actor model)
        {
            _context.Actors.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task DeleteActorAsync(int actorId)
        {
            var actor = await _context.Actors.FindAsync(actorId);

            _context.Actors.Remove(actor);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Actor>> FilterAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetActorAsync(int id)
        {
            var movie = await _context.Actors.FindAsync(id);

            return movie;
        }

        public async Task<Actor> UpdateActorAsync(Actor model)
        {
            var actor = await _context.Actors.FindAsync(model.ActorId);

            actor.Name = model.Name;

            await _context.SaveChangesAsync();

            return model;
        }
    }
}
