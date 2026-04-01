using EmployeeApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApi.Repository
{
    public class EmployeeRepository
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id=101,Name="Khadeeja", Department="IT",Salary=50000 },
            new Employee {Id=102,Name="shirin",Department="HR",Salary=44000},
            new Employee {Id=103,Name="sheikha", Department="IT",Salary=55000}
        };

        public List<Employee> GetAll()=> employees;

        public Employee GetById(int id) => employees.FirstOrDefault(e=>e.Id==id);

        public void Add(Employee emp)
        { 
            emp.Id = employees.Max(e => e.Id) + 1;
            employees.Add(emp);
        }

        public void Update(Employee emp)
        {
            var existingEmp = employees.FirstOrDefault(e => e.Id == emp.Id);
            if (existingEmp != null)
            {
                existingEmp.Name = emp.Name;
                existingEmp.Department = emp.Department;
                existingEmp.Salary = emp.Salary;
            }
        }

        public void Delete(int id)
        {
            var emp = employees.FirstOrDefault(e=>e.Id == id);
            if (emp != null)
                employees.Remove(emp);
        }
    }
}
