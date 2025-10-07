using Events_manager.Models;
using Microsoft.AspNetCore.Mvc;

namespace Events_manager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllEvents()
        {
            // ToList();

            return Ok();
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
