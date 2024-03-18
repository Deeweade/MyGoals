using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;
using MyGoals.Infrastructure.Configurations;

namespace MyGoals.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<BusinessProcess> BusinessProcesses { get; set; }
        public virtual DbSet<BusinessProcessStage> BusinessProcessStages { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeRequest> EmployeeRequests { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<Domain.Entities.EntityState> EntityStates { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<GoalOwnershipType> GoalOwnershipTypes { get; set; }
        public virtual DbSet<GoalType> GoalTypes { get; set; }
        public virtual DbSet<GroupRequest> GroupRequests { get; set; }
        public virtual DbSet<KeyResultType> KeyResultTypes { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<RequestStatus> RequestStatuses { get; set; }
        public virtual DbSet<RequestStatusesOrder> RequestStatusesOrders { get; set; }
        public virtual DbSet<RequestStatusTransition> RequestStatusTransitions { get; set; }
        public virtual DbSet<TypicalGoal> TypicalGoals { get; set; }

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

