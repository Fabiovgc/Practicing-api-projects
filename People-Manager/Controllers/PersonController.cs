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
<<<<<<< HEAD


        [Route("details/{Id:int}")]
        public IActionResult Details(int Id)
        {
            return View();
        }

=======
>>>>>>> 3edad37c41b6cfa1f3fa704c563b63ec34c20960
    }
}
