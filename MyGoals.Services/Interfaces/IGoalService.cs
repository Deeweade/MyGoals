using MyGoals.Domain.Entities;

namespace MyGoals.Services.Interfaces
{
    public interface IGoalService
    {
        Task<IEnumerable<Goal>> GetAllGoalsAsync();
        Task<Goal> GetGoalByCodeAsync(int id);
        Task<Goal> CreateGoalAsync(Goal goal);
        Task<Goal> UpdateGoalAsync(Goal goal);
        Task DeleteGoalAsync(int id);
    }
}

