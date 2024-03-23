using MyGoals.Infrastructure.Data;
using MyGoals.Domain.Repositories;
using MyGoals.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyGoals.Infrastructure.Repositories
{
    public class PeriodRepository : IPeriodRepository
    {
        private readonly ApplicationDbContext _context;

        public PeriodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Period>> GetAllAsync()
        {
            return await _context.Periods.ToListAsync();
        }

        public async Task<Period> GetByIdAsync(int id)
        {
            return await _context.Periods.FindAsync(id);
        }

        public async Task<Period> AddAsync(Period period)
        {
            _context.Periods.Add(period);
            await _context.SaveChangesAsync();
            return period;
        }

        public async Task<Period> UpdateAsync(Period period)
        {
            _context.Periods.Update(period);
            await _context.SaveChangesAsync();
            return period;
        }

        public async Task DeleteAsync(int id)
        {
            var period = await GetByIdAsync(id);
            if (period != null)
            {
                _context.Periods.Remove(period);
                await _context.SaveChangesAsync();
            }
        }
    }
}

