using MyGoals.Domain.Entities;

namespace MyGoals.Domain.Repositories
{
    public interface IGoalRepository
    {
        Task<IEnumerable<Goal>> GetAllAsync();
        Task<Goal> GetActiveByCodeAsync(int id);
        Task<Goal> AddAsync(Goal goal);
        Task<Goal> UpdateAsync(Goal goal);
        Task DeleteAsync(int id);
    }
}

