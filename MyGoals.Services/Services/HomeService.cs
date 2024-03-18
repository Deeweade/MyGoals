using MyGoals.Domain.Repositories;
using MyGoals.Services.Interfaces;

namespace MyGoals.Services.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _repository;

        public HomeService(IHomeRepository repository)
        {
            _repository = repository;
        }

        public async Task FillCurrentYearPeriods()
        {
            await _repository.FillCurrentYearPeriods();
        }

        public async Task FillDbConstants()
        {
            await _repository.FillDbConstants();
        }
    }
}

