using People_Manager.Data;
using People_Manager.Models;

namespace People_Manager.Service
{
    public class PeopleService : IPeopleService
    {
        private readonly PeopleManagerDbContext _context;

        public PeopleService(PeopleManagerDbContext context)
        {
            _context = context;
        }

        public List<Person> GetAll()
        {
            var personLIst = new List<Person>();

            personLIst.Add(new Person
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                BirthDate = new DateTime(1990, 1, 1),
                CPF = "12345678901",
                TipoSanguineo = Models.Enum.ETipoSanguineo.O_POSITIVE
            });

            return personLIst;
        }
    }
}
