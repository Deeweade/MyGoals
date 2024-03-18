using System;
using MyGoals.Domain.Entities;

namespace MyGoals.Domain.Repositories
{
    public interface IEmployeeRequestRepository
    {
        Task<IEnumerable<EmployeeRequest>> GetAllAsync();
        Task<EmployeeRequest> GetActiveByCodeAsync(int id);
        Task<EmployeeRequest> AddAsync(EmployeeRequest employeeRequest);
        Task<EmployeeRequest> UpdateAsync(EmployeeRequest employeeRequest);
        Task DeleteAsync(int id);
    }
}

