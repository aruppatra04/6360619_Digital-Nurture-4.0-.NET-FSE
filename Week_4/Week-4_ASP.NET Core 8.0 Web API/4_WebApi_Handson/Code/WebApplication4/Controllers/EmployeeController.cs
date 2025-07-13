using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
    {
        new Employee
        {
            Id = 1,
            Name = "John",
            Salary = 50000,
            Permanent = true,
            DateOfBirth = new DateTime(1990, 5, 1),
            Department = new Department { Id = 1, Name = "IT" },
            Skills = new List<Skill>
            {
                new Skill { Id = 1, Name = "C#" },
                new Skill { Id = 2, Name = "SQL" }
            }
        },
        new Employee
        {
            Id = 2,
            Name = "Jane",
            Salary = 60000,
            Permanent = false,
            DateOfBirth = new DateTime(1992, 7, 10),
            Department = new Department { Id = 2, Name = "HR" },
            Skills = new List<Skill>
            {
                new Skill { Id = 3, Name = "Communication" }
            }
        }
    };

        // ✅ GET all employees
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // GET employee by ID
        [HttpGet("{id}")]
        public ActionResult<Employee> GetById(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound($"Employee with ID {id} not found");

            return Ok(emp);
        }

        // POST - Create a new employee
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee emp)
        {
            emp.Id = employees.Max(e => e.Id) + 1; // auto-increment ID
            employees.Add(emp);
            return CreatedAtAction(nameof(GetById), new { id = emp.Id }, emp);
        }

        // PUT - Update employee by ID
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return BadRequest("Invalid employee id");

            emp.Name = updatedEmp.Name;
            emp.Salary = updatedEmp.Salary;
            emp.Permanent = updatedEmp.Permanent;
            emp.DateOfBirth = updatedEmp.DateOfBirth;
            emp.Department = updatedEmp.Department;
            emp.Skills = updatedEmp.Skills;

            return Ok(emp);
        }

        // DELETE - Remove employee by ID
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound($"Employee with ID {id} not found");

            employees.Remove(emp);
            return NoContent();
        }
    }

}
