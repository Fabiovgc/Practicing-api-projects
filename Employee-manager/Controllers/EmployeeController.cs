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
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Employee employee)
        {
            var employeeToUpdate = _context.Employees.SingleOrDefault(j => j.Id == id);
            if (employeeToUpdate == null)
            {
                return NotFound();
            }

            employeeToUpdate.Update(employee.Name, employee.Position, employee.Department, employee.Salary);

            _context.Employees.Update(employeeToUpdate);
            _context.SaveChanges();

            // Why does Update comes from _context.Employees?
            // Because it is a method of the Employee entity class that updates its properties.
            // The _context.Employees is a DbSet<Employee> that represents the collection of Employee entities in the database.
            // When we retrieve an Employee entity from the DbSet, we can call its Update method to modify its properties.

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}
