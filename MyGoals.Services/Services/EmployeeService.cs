using MyGoals.Domain.Entities;
using MyGoals.Domain.Repositories;
using MyGoals.Services.Interfaces;

namespace MyGoals.Services.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public IEnumerable<Employee> GetAllEmployees()
    {
        return _employeeRepository.GetAll();
    }

    public Employee GetEmployeeById(int id)
    {
        return _employeeRepository.GetById(id);
    }

    public Employee CreateEmployee(Employee employee)
    {
        return _employeeRepository.Add(employee);
    }

    public Employee UpdateEmployee(Employee employee)
    {
        return _employeeRepository.Update(employee);
    }

    public void DeleteEmployee(int id)
    {
        _employeeRepository.Delete(id);
    }
}

