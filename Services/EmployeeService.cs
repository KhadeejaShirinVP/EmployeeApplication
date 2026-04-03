using EmployeeApi.Models;
using EmployeeApi.Repository;

namespace EmployeeApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _repository;

        public EmployeeService(EmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<Employee> GetAll() => _repository.GetAll();
        public Employee GetById(int id) =>_repository.GetById(id);
        public void Add(Employee employee) => _repository.Add(employee);
        public void Update(Employee employee) => _repository.Update(employee);
        public void Delete(int id) => _repository.Delete(id);
    }
}
