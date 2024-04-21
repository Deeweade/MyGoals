using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;

namespace MyGoals.Infrastructure.Configurations
{
    internal sealed class GoalConfiguration : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.HasOne(g => g.EmployeeRequest)
                .WithMany(e => e.Goals)
                .HasForeignKey(g => g.EmployeeRequestCode)
                .HasPrincipalKey(e => e.Code)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasQueryFilter(g => g.EmployeeRequest.EntityStateId == (int)EntityStates.Active);

            builder.HasMany<Comment>()
                .WithOne(x => x.Goal)
                .HasForeignKey(x => x.GoalCode)
                .HasPrincipalKey(x => x.Code);
        }
    }
}

