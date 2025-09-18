using Microsoft.AspNetCore.Mvc;
using People_Manager.Models; 

namespace People_Manager.Controllers
{
    [Route("User")]
    public class PersonController : Controller
    {
        [Route("start")]
        public IActionResult Index()
        {
            return View();
        }



        [Route("details/{Id:int}")]
        public IActionResult Details(int Id)
        {
            var usuario = new Person(1, "Fabio", "Colonese", DateTime.Now);
            return View(usuario);
        }


    }
}
