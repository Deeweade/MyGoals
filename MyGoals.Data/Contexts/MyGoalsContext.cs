using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;

namespace MyGoals.Data.Contexts
{
    public class MyGoalsContext : DbContext
    {
        public MyGoalsContext(DbContextOptions<MyGoalsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<BusinessProcess> BusinessProcesses { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeRequest> EmployeeRequests { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<Domain.Entities.EntityState> EntityStates { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<GoalOwnershipType> GoalOwnershipTypes { get; set; }
        public virtual DbSet<GoalStatus> GoalStatuses { get; set; }
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
            SetGoalDependencies(builder);
            SetEmployeeRequestDependencies(builder);

            base.OnModelCreating(builder);
        }

        private void SetGoalDependencies(ModelBuilder builder)
        {
            builder.Entity<Goal>()
                .HasOne<EmployeeRequest>()
                .WithMany(er => er.Goals)
                .HasForeignKey(g => g.EmployeeRequestCode);

            builder.Entity<EmployeeRequest>()
                .HasQueryFilter(er => er.EntityStateId == (int)Domain.Enums.EntityStates.Active);

            builder.Entity<Goal>()
                .HasOne<GoalType>()
                .WithMany(x => x.Goals)
                .HasForeignKey(x => x.GoalTypeId);

            builder.Entity<Goal>()
                .HasOne<Period>()
                .WithMany(x => x.Goals)
                .HasForeignKey(x => x.PeriodId);

            builder.Entity<Goal>()
                .HasOne<Employee>()
                .WithMany(x => x.Goals)
                .HasForeignKey(x => x.EmployeeId);

            builder.Entity<Goal>()
                .HasOne<KeyResultType>()
                .WithMany(x => x.Goals)
                .HasForeignKey(x => x.KeyResultTypeId);

            builder.Entity<Goal>()
                .HasOne<TypicalGoal>()
                .WithMany(x => x.Goals)
                .HasForeignKey(x => x.TypicalGoalId);

            builder.Entity<Goal>()
                .HasMany<Comment>()
                .WithOne(x => x.Goal)
                .HasForeignKey(x => x.GoalCode);
        }

        private void SetEmployeeRequestDependencies(ModelBuilder builder)
        {
            builder.Entity<EmployeeRequest>()
                .HasMany<Goal>()
                .WithOne(er => er.EmployeeRequest)
                .HasForeignKey(g => g.EmployeeRequestCode);

            builder.Entity<Goal>()
                .HasQueryFilter(er => er.EntityStateId == (int)Domain.Enums.EntityStates.Active);

            builder.Entity<EmployeeRequest>()
                .HasOne<GroupRequest>()
                .WithMany(x => x.EmployeeRequests)
                .HasForeignKey(x => x.GroupRequestId);

            builder.Entity<EmployeeRequest>()
                .HasOne<Period>()
                .WithMany(x => x.EmployeeRequests)
                .HasForeignKey(x => x.PeriodId);

            builder.Entity<EmployeeRequest>()
                .HasOne<Employee>()
                .WithMany(x => x.EmployeeRequests)
                .HasForeignKey(x => x.EmployeeId);

            builder.Entity<EmployeeRequest>()
                .HasOne<RequestStatus>()
                .WithMany(x => x.EmployeeRequests)
                .HasForeignKey(x => x.RequestStatusId);
        }
    }
}

