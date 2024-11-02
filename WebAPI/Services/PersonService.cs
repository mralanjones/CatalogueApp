using WebAPI.Services.Contracts;

namespace WebAPI.Services
{
    public class PersonService : IPersonService
    {
        private readonly DataContext _context;

        public PersonService(DataContext context)
        {
            _context = context;
        }

        public async Task<Person> CreatePersonAsync(Person model)
        {
            _context.People.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task DeletePersonAsync(int id)
        {
            var person = await _context.People.FindAsync(id);

            _context.People.Remove(person);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Person>> FilterAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            var movie = await _context.People.FindAsync(id);

            return movie;
        }

        public async Task<Person> UpdatePersonAsync(Person model)
        {
            var person = await _context.People.FindAsync(model.PersonId);

            person.Name = model.Name;

            await _context.SaveChangesAsync();

            return model;
        }
    }
}
