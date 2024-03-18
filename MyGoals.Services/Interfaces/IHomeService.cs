using System;

namespace MyGoals.Services.Interfaces
{
    public interface IHomeService
    {
        Task FillDbConstants();
        Task FillCurrentYearPeriods();
    }
}

