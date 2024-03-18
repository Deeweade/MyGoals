using System;
using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;
using MyGoals.Domain.Repositories;
using MyGoals.Infrastructure.Data;

namespace MyGoals.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.AsNoTracking().ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.AsNoTracking().FirstOrDefault(e => e.Id == id);
        }

        public Employee Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return employee;
        }

        public Employee Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();

            return employee;
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}

