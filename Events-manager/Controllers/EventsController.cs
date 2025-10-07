using Events_manager.Models;
using Events_manager.NewFolder;
using Microsoft.AspNetCore.Mvc;

namespace Events_manager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {

        private readonly EventsDbContext _context;

        public EventsController(EventsDbContext context)
        {
            _context = context;
        }



        [HttpGet]
        public IActionResult GetAllEvents()
        {
            var allEvents = _context.Events.ToList();

            return Ok(allEvents);
        }


        [HttpGet("{id:int}")]
        public IActionResult GetEventsById(int id)
        {
            // SingleOrDefault
            return Ok();
        }

        [HttpPost]
        public IActionResult PostEvent(Event _event)
        {
            // CreatedAtAction

            return CreatedAtAction(nameof(GetEventsById), new { id = _event.Id }, _event);

            // retornar 
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateEventById(int id)
        {
            // if(){ return NotFound() }

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteEvent()
        {
            // if(){ return NotFound() }

            return NoContent();
        }



    }
}
