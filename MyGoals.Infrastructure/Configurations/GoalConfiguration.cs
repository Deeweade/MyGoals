using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;
using MyGoals.Domain.Enums;

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

            //builder.HasAlternateKey(er => new { er.Code, er.EntityStateId });

            //builder.HasOne<EmployeeRequest>()
            //    .WithMany(er => er.Goals)
            //    .HasForeignKey(x => new { x.Code, x.EntityStateId });

            //builder.HasQueryFilter(er => er.EntityStateId == (int)Domain.Enums.EntityStates.Active);

            builder.HasMany<Comment>()
                .WithOne(x => x.Goal)
                .HasForeignKey(x => x.GoalCode);
        }
    }
}

