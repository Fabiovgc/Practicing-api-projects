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
            return View("~/Views/Person/Index.cshtml");
            
            //TempData["SucessoRedirecionamento"] = "O redirecionamento foi um sucesso";
        }



        [Route("details")]
        public IActionResult PeopleDetails()
        {
            
            // ViewBag is a dynamic object that allows you to pass data from the controller to the view
            ViewBag.TextoDescricao = "Texto da tela de descrição";

            ViewData["DataAtual"] = DateTime.Now;

            // TempData["SucessoRedirecionamento"] = "O redirecionamento foi um sucesso";

            var people = new List<Person>();
            people.Add(new Person(1, "Fabio", "Colonese", DateTime.Now));
            people.Add(new Person(2, "Mario", "Rossi", DateTime.Now));
            people.Add(new Person(3, "Luigi", "Verdi", DateTime.Now));
            people.Add(new Person(4, "Anna", "Bianchi", DateTime.Now));

            return View(people);

            //return RedirectToAction("Index");
        }



        [Route("details/{Id:int}")]
        public IActionResult PersonDetails(int Id)
        {
            ViewBag.TextoDescricao  = "Texto da tela de descrição";

            ViewData["DataAtual"] = DateTime.Now;

            //TempData["SucessoRedirecionamento"] = "O redirecionamento foi um sucesso";

            var people = new List<Person>
            {
                new Person(1, "Fabio", "Colonese", DateTime.Now),
                new Person(2, "Mario", "Rossi", DateTime.Now),
                new Person(3, "Luigi", "Verdi", DateTime.Now),
                new Person(4, "Anna", "Bianchi", DateTime.Now)
            };

            var person = people.FirstOrDefault(p => p.Id == Id);

            if (person == null)
            {
                return NotFound();
            }

            //var person = new Person(1, "Fabio", "Colonese", DateTime.Now);
            
            return View("~/Views/Person/PersonDetails.cshtml", person);
            
            //return RedirectToAction("Index");
        }


    }
}
