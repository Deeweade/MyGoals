namespace MyGoals.Domain.Repositories
{
    public interface IHomeRepository
    {
        Task FillDbConstants();
        Task FillCurrentYearPeriods();
    }
}

