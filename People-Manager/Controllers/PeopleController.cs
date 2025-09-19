using Microsoft.AspNetCore.Mvc;
using People_Manager.Models; 

namespace People_Manager.Controllers
{
    [Route("User")]
    public class PeopleController : Controller
    {
        [Route("start")]
        public IActionResult Index()
        {
            return View();
        }



        [Route("details")]
        public IActionResult PeopleDetails()
        {
            var people = new List<Person>();
            people.Add(new Person(1, "Fabio", "Colonese", DateTime.Now));
            people.Add(new Person(2, "Mario", "Rossi", DateTime.Now));
            people.Add(new Person(3, "Luigi", "Verdi", DateTime.Now));
            people.Add(new Person(4, "Anna", "Bianchi", DateTime.Now));

            return View(people);
        }



        [Route("details/{Id:int}")]
        public IActionResult PersonDetails(int Id)
        {
            var person = new Person(1, "Fabio", "Colonese", DateTime.Now);
            return View(person);
        }


    }
}
