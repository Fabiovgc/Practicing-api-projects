using Employee_manager.Entities;
using Employee_manager.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Employee_manager.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : ControllerBase
    {

       private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            // // 
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var employee = _context.Employees.SingleOrDefault(j => j.Id == id);

            if (employee == null)
            {
                return NotFound();
            }
            
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Employee employee)
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
