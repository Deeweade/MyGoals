using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;

namespace MyGoals.Infrastructure.Configurations
{
    internal sealed class GoalConfiguration : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.HasOne<EmployeeRequest>()
                .WithMany(er => er.Goals)
                .HasForeignKey(g => g.EmployeeRequestCode);

            builder.HasQueryFilter(er => er.EntityStateId == (int)Domain.Enums.EntityStates.Active);

            //builder.HasOne<GoalType>()
            //    .WithMany(x => x.Goals)
            //    .HasForeignKey(x => x.GoalTypeId);

            //builder.HasOne<Period>()
            //    .WithMany(x => x.Goals)
            //    .HasForeignKey(x => x.PeriodId);

            //builder.HasOne<Employee>()
            //    .WithMany(x => x.Goals)
            //    .HasForeignKey(x => x.EmployeeId);

            //builder.HasOne<KeyResultType>()
            //    .WithMany(x => x.Goals)
            //    .HasForeignKey(x => x.KeyResultTypeId);

            //builder.HasOne<TypicalGoal>()
            //    .WithMany(x => x.Goals)
            //    .HasForeignKey(x => x.TypicalGoalId);

            builder.HasMany<Comment>()
                .WithOne(x => x.Goal)
                .HasForeignKey(x => x.GoalCode);
        }
    }
}

