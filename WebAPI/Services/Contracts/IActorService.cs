namespace WebAPI.Services.Contracts
{
    public interface IActorService
    {
        Task<Actor> GetActorAsync(int id);
        Task<Actor> CreateActorAsync(Actor model);
        Task<Actor> UpdateActorAsync(Actor model);
        Task DeleteActorAsync(int movieId);
        Task<IEnumerable<Actor>> FilterAsync();
    }
}
