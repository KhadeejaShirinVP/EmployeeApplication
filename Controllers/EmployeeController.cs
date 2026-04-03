using EmployeeApi.Models;
using EmployeeApi.Repository;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        //private readonly EmployeeRepository _repo;
        private readonly IEmployeeService _employeeService;

        public EmployeeController( IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employeeService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var emp= _employeeService.GetById(id);
            if(emp == null)
                return NotFound();
            return Ok(emp);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.Add(employee);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.Update(employee);
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _employeeService.Delete(id);
            return Ok();
        }
    }
}
