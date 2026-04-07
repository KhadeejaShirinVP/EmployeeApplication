using EmployeeApi.Common;
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
        private readonly IEmployeeService _employeeService;

        public EmployeeController( IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new ApiResponse<List<Employee>>
            {
                Success = true,
                Message = "Data retrieved successfully",
                Data = _employeeService.GetAll()
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var emp= _employeeService.GetById(id);
            if(emp == null)
            {
                return NotFound(new ApiResponse<string>
                {
                    Success = false,
                    Message = "Employee not found",
                    Data = null
                });
            }
                
            return Ok(new ApiResponse<Employee>
            {
                Success = true,
                Message = "Retrieved successfully",
                Data = emp
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.Add(employee);
            return Ok(new ApiResponse<Employee>
            {
                Success = true,
                Message = "Employee added successfully",
                Data = employee
            });
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var existing = _employeeService.GetById(employee.Id);

            if (existing == null)
            {
                return NotFound(new ApiResponse<string>
                {
                    Success = false,
                    Message = "Employee not found",
                    Data = null
                });
            }
            _employeeService.Update(employee);

            return Ok(new ApiResponse<Employee>
            {
                Success = true,
                Message = "Employee updated successfully",
                Data = employee
            });
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var existing = _employeeService.GetById(id);

            if (existing == null)
            {
                return NotFound(new ApiResponse<string>
                {
                    Success = false,
                    Message = "Employee not found",
                    Data = null
                });
            }
            _employeeService.Delete(id);
            return Ok(new ApiResponse<string>
            {
                Success = true,
                Message = "Employee deleted successfully",
                Data=null
            });
        }
    }
}
