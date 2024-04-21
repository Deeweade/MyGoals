using MyGoals.Domain.Entities;

namespace MyGoals.Services.Interfaces
{
    public interface IPeriodService
    {
        Task<IEnumerable<Period>> GetAllPeriodsAsync();
        Task<Period> GetPeriodByIdAsync(int id);
        Task<Period> CreatePeriodAsync(Period period);
        Task<Period> UpdatePeriodAsync(Period period);
        Task DeletePeriodAsync(int id);
    }
}

