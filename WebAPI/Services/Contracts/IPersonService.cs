namespace WebAPI.Services.Contracts
{
    public interface IPersonService
    {
        Task<Person> GetPersonAsync(int id);
        Task<Person> CreatePersonAsync(Person model);
        Task<Person> UpdatePersonAsync(Person model);
        Task DeletePersonAsync(int movieId);
        Task<IEnumerable<Person>> FilterAsync();
    }
}
