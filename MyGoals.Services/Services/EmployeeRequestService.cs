using MyGoals.Domain.Repositories;
using MyGoals.Services.Interfaces;
using MyGoals.Domain.Entities;

namespace MyGoals.Services.Services
{
    public class EmployeeRequestService : IEmployeeRequestService
    {
        private readonly IEmployeeRequestRepository _employeeRequestRepository;

        public EmployeeRequestService(IEmployeeRequestRepository employeeRequestRepository)
        {
            _employeeRequestRepository = employeeRequestRepository;
        }

        public async Task<IEnumerable<EmployeeRequest>> GetAllEmployeeRequestsAsync()
        {
            return await _employeeRequestRepository.GetAllAsync();
        }

        public async Task<EmployeeRequest> GetActiveByCodeAsync(int code)
        {
            return await _employeeRequestRepository.GetActiveByCodeAsync(code);
        }

        public async Task<EmployeeRequest> CreateEmployeeRequest(EmployeeRequest employeeRequest)
        {
            return await _employeeRequestRepository.AddAsync(employeeRequest);
        }

        public async Task<EmployeeRequest> UpdateEmployeeRequest(EmployeeRequest employeeRequest)
        {
            return await _employeeRequestRepository.UpdateAsync(employeeRequest);
        }

        public async Task DeleteEmployeeRequestAsync(int code)
        {
            await _employeeRequestRepository.DeleteAsync(code);
        }
    }
}

