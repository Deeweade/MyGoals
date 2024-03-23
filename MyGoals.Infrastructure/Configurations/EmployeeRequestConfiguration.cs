using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;

namespace MyGoals.Infrastructure.Configurations
{
    internal sealed class EmployeeRequestConfiguration : IEntityTypeConfiguration<EmployeeRequest>
    {
        public void Configure(EntityTypeBuilder<EmployeeRequest> builder)
        {
            builder.HasMany(e => e.Goals)
                .WithOne(g => g.EmployeeRequest)
                .HasForeignKey(g => g.EmployeeRequestCode)
                .HasPrincipalKey(e => e.Code)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

