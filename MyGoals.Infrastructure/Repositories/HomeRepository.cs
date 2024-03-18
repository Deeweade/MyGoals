using MyGoals.Domain.Entities;
using MyGoals.Domain.Repositories;
using MyGoals.Infrastructure.Data;

namespace MyGoals.Infrastructure.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _context;

        public HomeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task FillDbConstants()
        {
            await FillEmployeeRoles();
            await FillGoalOwnershipTypes();
            await FillBusinessProcesses();
            await FillBusinessProcessStages();
            await FillEntityStates();
            await FillGoalTypes();
            await FillKeyResultTypes();
            await FillCurrentYearPeriods();
        }

        public async Task FillCurrentYearPeriods()
        {
            if (_context.Periods.Count() == 0)
            {
                var types = new List<Period>
                {
                    new Period
                    {
                        Name = $"{DateTime.Now.Year} год",
                        YearNumber = DateTime.Now.Year,
                        QuarterNumber = 0,
                        DateStart = new DateTime(DateTime.Now.Year, 1, 1),
                        DateEnd = new DateTime(DateTime.Now.Year, 12, 31)
                    },
                    new Period
                    {
                        Name = $"{DateTime.Now.Year} год, 1 квартал",
                        YearNumber = DateTime.Now.Year,
                        QuarterNumber = 1,
                        DateStart = new DateTime(DateTime.Now.Year, 1, 1),
                        DateEnd = new DateTime(DateTime.Now.Year, 3, 31)
                    },
                    new Period
                    {
                        Name = $"{DateTime.Now.Year} год, 2 квартал",
                        YearNumber = DateTime.Now.Year,
                        QuarterNumber = 2,
                        DateStart = new DateTime(DateTime.Now.Year, 4, 1),
                        DateEnd = new DateTime(DateTime.Now.Year, 6, 30)
                    },
                    new Period
                    {
                        Name = $"{DateTime.Now.Year} год, 3 квартал",
                        YearNumber = DateTime.Now.Year,
                        QuarterNumber = 3,
                        DateStart = new DateTime(DateTime.Now.Year, 7, 1),
                        DateEnd = new DateTime(DateTime.Now.Year, 9, 30)
                    },
                    new Period
                    {
                        Name = $"{DateTime.Now.Year} год, 4 квартал",
                        YearNumber = DateTime.Now.Year,
                        QuarterNumber = 4,
                        DateStart = new DateTime(DateTime.Now.Year, 10, 1),
                        DateEnd = new DateTime(DateTime.Now.Year, 12, 31)
                    }
                };

                _context.Periods.AddRange(types);

                await _context.SaveChangesAsync();
            }
        }

        private async Task FillKeyResultTypes()
        {
            if (_context.KeyResultTypes.Count() == 0)
            {
                var types = new List<KeyResultType>
                {
                    new KeyResultType { Title = "шт." },
                    new KeyResultType { Title = "%" },
                    new KeyResultType { Title = "₽" },
                    new KeyResultType { Title = "млн ₽" },
                    new KeyResultType { Title = "млрд ₽" }
                };

                _context.KeyResultTypes.AddRange(types);

                await _context.SaveChangesAsync();
            }
        }

        private async Task FillGoalTypes()
        {
            if (_context.GoalTypes.Count() == 0)
            {
                var types = new List<GoalType>
                {
                    new GoalType { Name = "Годовая цель" },
                    new GoalType { Name = "ЛОКР" },
                    new GoalType { Name = "Критерий достижения" },
                    new GoalType { Name = "Квартальная цель" }
                };

                _context.GoalTypes.AddRange(types);

                await _context.SaveChangesAsync();
            }
        }

        private async Task FillEntityStates()
        {
            if (_context.EntityStates.Count() == 0)
            {
                var types = new List<EntityState>
                {
                    new EntityState { Name = "Active" },
                    new EntityState { Name = "Cancelled" },
                    new EntityState { Name = "Completed" }
                };

                _context.EntityStates.AddRange(types);

                await _context.SaveChangesAsync();
            }
        }

        private async Task FillBusinessProcessStages()
        {
            if (_context.BusinessProcessStages.Count() == 0)
            {
                var types = new List<BusinessProcessStage>
                {
                    new BusinessProcessStage { Name = "Черновик", BusinessProcessId = 1 },
                    new BusinessProcessStage { Name = "Согласование", BusinessProcessId = 1 },
                    new BusinessProcessStage { Name = "Утверждено", BusinessProcessId = 1 },
                    new BusinessProcessStage { Name = "Корректировка", BusinessProcessId = 2 },
                    new BusinessProcessStage { Name = "Согласование изменений", BusinessProcessId = 2 },
                    new BusinessProcessStage { Name = "Изменения утверждены", BusinessProcessId = 2 },
                    new BusinessProcessStage { Name = "Самооценка", BusinessProcessId = 3 },
                    new BusinessProcessStage { Name = "Оценка руководителем", BusinessProcessId = 3 },
                    new BusinessProcessStage { Name = "Оценка утверджена", BusinessProcessId = 3 }
                };

                _context.BusinessProcessStages.AddRange(types);

                await _context.SaveChangesAsync();
            }
        }

        private async Task FillBusinessProcesses()
        {
            if (_context.BusinessProcesses.Count() == 0)
            {
                var types = new List<BusinessProcess>
                {
                    new BusinessProcess { Name = "Постановка целей" },
                    new BusinessProcess { Name = "Корректировка целей" },
                    new BusinessProcess { Name = "Промежуточная оценка целей" },
                    new BusinessProcess { Name = "Итоговая оценка целей" }
                };

                _context.BusinessProcesses.AddRange(types);

                await _context.SaveChangesAsync();
            }
        }

        private async Task FillGoalOwnershipTypes()
        {
            if (_context.GoalOwnershipTypes.Count() == 0)
            {
                var types = new List<GoalOwnershipType>
                {
                    new GoalOwnershipType { Name = "Личные цели" },
                    new GoalOwnershipType { Name = "Типовые цели" },
                    new GoalOwnershipType { Name = "Все" }
                };

                _context.GoalOwnershipTypes.AddRange(types);

                await _context.SaveChangesAsync();
            }
        }

        private async Task FillEmployeeRoles()
        {
            if (_context.EmployeeRoles.Count() == 0)
            {
                var roles = new List<EmployeeRole>
                {
                    new EmployeeRole { Title = "Я" },
                    new EmployeeRole { Title = "Прямой руководитель" },
                    new EmployeeRole { Title = "Вышестоящий руководитель" },
                    new EmployeeRole { Title = "Коллега" }
                };

                _context.EmployeeRoles.AddRange(roles);

                await _context.SaveChangesAsync();
            }
        }
    }
}

