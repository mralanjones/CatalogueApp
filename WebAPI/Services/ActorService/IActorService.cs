namespace WebAPI.Services.ActorService
{
    public interface IActorService
    {
        Task<Actor> GetActorAsync(int id);
        Task<Actor> CreateActorAsync(Actor model);
        Task<Actor> UpdateActorAsync(Actor model);
        Task<int> DeleteActorAsync(int movieId);
        Task<IEnumerable<Actor>> FilterAsync();
    }
}
