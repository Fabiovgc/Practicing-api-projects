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

            ViewBag.RegisterSuccess = TempData["SuccessCreate"];
            return View("~/Views/Person/Index.cshtml");
        }



        [Route("details")]
        public IActionResult PeopleDetails()
        {
            
            ViewBag.TextoDescricao = "Texto da tela de descrição";

            ViewData["DataAtual"] = DateTime.Now;


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
            ViewBag.TextoDescricao  = "Texto da tela de descrição";

            ViewData["DataAtual"] = DateTime.Now;

            
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

            
            
            return View("~/Views/Person/PersonDetails.cshtml", person);
            
            
        }

        [HttpGet]
        [Route("SearchByUrl")]
        public IActionResult SearchByUrl(string name, string surname)
        {
            var listaUsuario = new List<Person>
            {
                new Person(1, "Fabio", "Colonese", DateTime.Now),
                new Person(2, "Mario", "Rossi", DateTime.Now),
                new Person(3, "Luigi", "Verdi", DateTime.Now),
                new Person(4, "Anna", "Bianchi", DateTime.Now)
            };

            var pessoaSelecionada = listaUsuario.FirstOrDefault(n => n.Name == name && n.Surname == surname);

            if (pessoaSelecionada == null)
            {
                return NotFound();
            }

            return View("~/Views/Person/SearchByUrl.cshtml", pessoaSelecionada);
        }

        [HttpGet]
        [Route("CreateUser")]
        public IActionResult CreateUser()
        {
            return View("~/Views/Person/CreateUser.cshtml");
        }


        [HttpPost]
        [Route("CreateUser")]
        public IActionResult CreateUser(string name, string surname)
        {
            TempData["SuccessCreate"] = $"The user {name} {surname} is created!";
            return RedirectToAction("Index");
        }


    }
}
