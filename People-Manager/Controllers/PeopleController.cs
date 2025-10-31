using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using People_Manager.Models;
using People_Manager.Service;

namespace People_Manager.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public IActionResult Index()
        {
            var getAll = _peopleService.GetAll();
            return View();
        }
    }
}
