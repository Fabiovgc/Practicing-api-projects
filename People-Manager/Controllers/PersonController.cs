using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

    }
}
