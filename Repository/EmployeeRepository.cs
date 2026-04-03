using EmployeeApi.Data;
using EmployeeApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApi.Repository
{
    public class EmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context) 
        {
            _context = context;
        }

        public List<Employee> GetAll() => _context.Employees.ToList();

        public Employee GetById(int id) => _context.Employees.Find(id);

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp= _context.Employees.Find(id);
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
            }
        }


        //private static List<Employee> employees = new List<Employee>
        //{
        //    new Employee { Id=101,Name="Khadeeja", Department="IT",Salary=50000 },
        //    new Employee {Id=102,Name="shirin",Department="HR",Salary=44000},
        //    new Employee {Id=103,Name="sheikha", Department="IT",Salary=55000}
        //};

        //public List<Employee> GetAll()=> employees;

        //public Employee GetById(int id) => employees.FirstOrDefault(e=>e.Id==id);

        //public void Add(Employee emp)
        //{ 
        //    emp.Id = employees.Max(e => e.Id) + 1;
        //    employees.Add(emp);
        //}

        //public void Update(Employee emp)
        //{
        //    var existingEmp = employees.FirstOrDefault(e => e.Id == emp.Id);
        //    if (existingEmp != null)
        //    {
        //        existingEmp.Name = emp.Name;
        //        existingEmp.Department = emp.Department;
        //        existingEmp.Salary = emp.Salary;
        //    }
        //}

        //public void Delete(int id)
        //{
        //    var emp = employees.FirstOrDefault(e=>e.Id == id);
        //    if (emp != null)
        //        employees.Remove(emp);
        //}
    }
}
