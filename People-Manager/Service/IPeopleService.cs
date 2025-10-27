using People_Manager.Models;

namespace People_Manager.Service
{
    public interface IPeopleService
    {
        List<Person> GetAll();
    }
}
