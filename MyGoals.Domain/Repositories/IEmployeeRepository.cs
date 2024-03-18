using System;
using MyGoals.Domain.Entities;

namespace MyGoals.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        void Delete(int id);
    }
}

