﻿using MyGoals.Domain.Repositories;
using MyGoals.Infrastructure.Data;
using MyGoals.Domain.Entities;
using MyGoals.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace MyGoals.Infrastructure.Repositories
{
    public class GoalRepository : IGoalRepository
    {
        private readonly ApplicationDbContext _context;

        public GoalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Goal>> GetAllAsync()
        {
            return await _context.Goals.ToListAsync();
        }

        public async Task<Goal> GetActiveByCodeAsync(int code)
        {
            return await _context.Goals
                .FirstOrDefaultAsync(x => x.Code == code && x.EntityStateId == (int)EntityStates.Active);
        }

        public async Task<Goal> AddAsync(Goal goal)
        {
            if (goal is null) throw new ArgumentNullException(nameof(goal));

            var maxCode = await _context.Goals.MaxAsync(x => x.Code);

            if (maxCode == 0) maxCode = 10000000;

            goal.Code = ++maxCode;
            goal.DateStart = DateTime.Now;
            goal.DateEnd = DateTime.MaxValue;
            goal.EntityStateId = (int)EntityStates.Active;

            _context.Goals.Add(goal);
            await _context.SaveChangesAsync();
            return goal;
        }

        public async Task<Goal> UpdateAsync(Goal goal)
        {
            if (goal is null) throw new ArgumentNullException(nameof(goal));

            var currentGoal = await _context.Goals
                .FirstOrDefaultAsync(x => x.Code == goal.Code && x.EntityStateId == (int)EntityStates.Active);

            var dateEnd = DateTime.Now;

            currentGoal.DateEnd = dateEnd;
            currentGoal.EntityStateId = (int)EntityStates.Cancelled;

            goal.DateStart = dateEnd;
            goal.EntityStateId = (int)EntityStates.Active;

            _context.Goals.Add(goal);
            await _context.SaveChangesAsync();
            return goal;
        }

        public async Task DeleteAsync(int id)
        {
            var goal = await GetActiveByCodeAsync(id);
            if (goal != null)
            {
                goal.DateEnd = DateTime.Now;
                goal.EntityStateId = (int)EntityStates.Cancelled;

                //_context.Goals.Remove(goal);
                await _context.SaveChangesAsync();
            }
        }
    }
}

