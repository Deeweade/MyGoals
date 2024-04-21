using MyGoals.Infrastructure.Configurations;
using MyGoals.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyGoals.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        internal virtual DbSet<BusinessProcess> BusinessProcesses { get; set; }
        internal virtual DbSet<BusinessProcessStage> BusinessProcessStages { get; set; }
        internal virtual DbSet<Comment> Comments { get; set; }
        internal virtual DbSet<Employee> Employees { get; set; }
        internal virtual DbSet<EmployeeRequest> EmployeeRequests { get; set; }
        internal virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        internal virtual DbSet<Domain.Entities.EntityState> EntityStates { get; set; }
        internal virtual DbSet<Goal> Goals { get; set; }
        internal virtual DbSet<GoalOwnershipType> GoalOwnershipTypes { get; set; }
        internal virtual DbSet<GoalType> GoalTypes { get; set; }
        internal virtual DbSet<GroupRequest> GroupRequests { get; set; }
        internal virtual DbSet<KeyResultType> KeyResultTypes { get; set; }
        internal virtual DbSet<Period> Periods { get; set; }
        internal virtual DbSet<RequestStatus> RequestStatuses { get; set; }
        internal virtual DbSet<RequestStatusesOrder> RequestStatusesOrders { get; set; }
        internal virtual DbSet<RequestStatusTransition> RequestStatusTransitions { get; set; }
        internal virtual DbSet<TypicalGoal> TypicalGoals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new GoalConfiguration());
            builder.ApplyConfiguration(new EmployeeRequestConfiguration());

            base.OnModelCreating(builder);
        }
    }
}

