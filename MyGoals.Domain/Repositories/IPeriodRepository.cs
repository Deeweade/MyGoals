using MyGoals.Domain.Entities;

namespace MyGoals.Domain.Repositories
{
    public interface IPeriodRepository
    {
        Task<IEnumerable<Period>> GetAllAsync();
        Task<Period> GetByIdAsync(int id);
        Task<Period> AddAsync(Period period);
        Task<Period> UpdateAsync(Period period);
        Task DeleteAsync(int id);
    }
}

