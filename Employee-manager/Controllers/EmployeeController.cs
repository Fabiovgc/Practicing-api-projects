using Employee_manager.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Employee_manager.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {

            // return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id)
        {
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}
