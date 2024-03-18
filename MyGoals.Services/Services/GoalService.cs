using MyGoals.Domain.Repositories;
using MyGoals.Services.Interfaces;
using MyGoals.Domain.Entities;

namespace MyGoals.Services.Services
{
    public class GoalService : IGoalService
    {
        private readonly IGoalRepository _goalRepository;

        public GoalService(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }

        public async Task<IEnumerable<Goal>> GetAllGoalsAsync()
        {
            return await _goalRepository.GetAllAsync();
        }

        public async Task<Goal> GetGoalByCodeAsync(int code)
        {
            return await _goalRepository.GetActiveByCodeAsync(code);
        }

        public async Task<Goal> CreateGoalAsync(Goal goal)
        {
            return await _goalRepository.AddAsync(goal);
        }

        public async Task<Goal> UpdateGoalAsync(Goal goal)
        {
            return await _goalRepository.UpdateAsync(goal);
        }

        public async Task DeleteGoalAsync(int code)
        {
            await _goalRepository.DeleteAsync(code);
        }
    }
}

