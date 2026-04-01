using EmployeeApi.Models;
using EmployeeApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _repo;

        public EmployeeController(EmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var emp= _repo.GetById(id);
            if(emp == null)
                return NotFound();
            return Ok(emp);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _repo.Add(employee);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _repo.Update(employee);
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _repo.Delete(id);
            return Ok();
        }

    }
}
