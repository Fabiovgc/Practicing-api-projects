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
    }
}
