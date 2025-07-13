using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // GET: api/Employee
        [HttpGet]
        [ActionName("GetAll")]
        [ProducesResponseType(200)]
        public IActionResult Get()
        {
            return Ok(new[] { "Emp1", "Emp2", "Emp3" });
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Employee {id}");
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] string employee)
        {
            return Ok($"Added {employee}");
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string employee)
        {
            return Ok($"Updated Employee {id} with value {employee}");
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleted Employee {id}");
        }
    }
}
