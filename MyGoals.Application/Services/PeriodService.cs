using MyGoals.Services.Interfaces;
using MyGoals.Domain.Repositories;
using MyGoals.Domain.Entities;

namespace MyGoals.Services.Services
{
    public class PeriodService : IPeriodService
    {
        private readonly IPeriodRepository _periodRepository;

        public PeriodService(IPeriodRepository periodRepository)
        {
            _periodRepository = periodRepository;
        }

        public async Task<IEnumerable<Period>> GetAllPeriodsAsync()
        {
            return await _periodRepository.GetAllAsync();
        }

        public async Task<Period> GetPeriodByIdAsync(int id)
        {
            return await _periodRepository.GetByIdAsync(id);
        }

        public async Task<Period> CreatePeriodAsync(Period period)
        {
            return await _periodRepository.AddAsync(period);
        }

        public async Task<Period> UpdatePeriodAsync(Period period)
        {
            return await _periodRepository.UpdateAsync(period);
        }

        public async Task DeletePeriodAsync(int id)
        {
            await _periodRepository.DeleteAsync(id);
        }
    }
}

