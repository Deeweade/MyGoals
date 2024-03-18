using MyGoals.Domain.Entities;

namespace MyGoals.Services.Interfaces
{
    public interface IEmployeeRequestService
    {
        Task<IEnumerable<EmployeeRequest>> GetAllEmployeeRequestsAsync();
        Task<EmployeeRequest> GetActiveByCodeAsync(int code);
        Task<EmployeeRequest> CreateEmployeeRequest(EmployeeRequest employeeRequest);
        Task<EmployeeRequest> UpdateEmployeeRequest(EmployeeRequest employeeRequest);
        Task DeleteEmployeeRequestAsync(int code);
    }
}

