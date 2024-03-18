using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Repositories;
using MyGoals.Infrastructure.Data;
using MyGoals.Domain.Entities;
using MyGoals.Domain.Enums;

namespace MyGoals.Infrastructure.Repositories
{
    public class EmployeeRequestRepository : IEmployeeRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeRequest>> GetAllAsync()
        {
            return await _context.EmployeeRequests
                .AsNoTracking()
                .Where(x => x.EntityStateId == (int)EntityStates.Active)
                .ToListAsync();
        }

        public async Task<EmployeeRequest> GetActiveByCodeAsync(int code)
        {
            return await _context.EmployeeRequests
                .AsNoTracking()
                .FirstOrDefaultAsync(er => er.Code == code && er.Code == (int)EntityStates.Active);
        }

        public async Task<EmployeeRequest> AddAsync(EmployeeRequest employeeRequest)
        {
            if (employeeRequest is null) throw new ArgumentNullException(nameof(employeeRequest));

            var maxCode = await _context.EmployeeRequests.MaxAsync(x => x.Code);

            if (maxCode is null || maxCode == 0) maxCode = 20000000;

            employeeRequest.Code = ++maxCode;
            employeeRequest.DateStart = DateTime.Now;
            employeeRequest.DateEnd = DateTime.MaxValue;
            employeeRequest.EntityStateId = (int)EntityStates.Active;

            _context.EmployeeRequests.Add(employeeRequest);
            _context.SaveChanges();
            return employeeRequest;
        }

        public async Task<EmployeeRequest> UpdateAsync(EmployeeRequest employeeRequest)
        {
            if (employeeRequest is null) throw new ArgumentNullException(nameof(employeeRequest));

            var currentRequest = await _context.EmployeeRequests
                .FirstOrDefaultAsync(x => x.Code == employeeRequest.Code && x.EntityStateId == (int)EntityStates.Active);

            var dateEnd = DateTime.Now;

            currentRequest.DateEnd = dateEnd;
            currentRequest.EntityStateId = (int)EntityStates.Cancelled;

            employeeRequest.DateStart = dateEnd;
            employeeRequest.EntityStateId = (int)EntityStates.Active;

            _context.EmployeeRequests.Add(employeeRequest);
            _context.SaveChanges();
            return employeeRequest;
        }

        public async Task DeleteAsync(int code)
        {
            var employeeRequest = await GetActiveByCodeAsync(code);
            if (employeeRequest != null)
            {
                employeeRequest.DateEnd = DateTime.Now;
                employeeRequest.EntityStateId = (int)EntityStates.Cancelled;

                //_context.EmployeeRequests.Remove(employeeRequest);
                _context.SaveChanges();
            }
        }
    }
}

