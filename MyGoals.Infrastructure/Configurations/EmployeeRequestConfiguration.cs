using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;

namespace MyGoals.Infrastructure.Configurations
{
    internal sealed class EmployeeRequestConfiguration : IEntityTypeConfiguration<EmployeeRequest>
    {
        public void Configure(EntityTypeBuilder<EmployeeRequest> builder)
        {
            builder.HasMany<Goal>()
                .WithOne(er => er.EmployeeRequest)
                .HasForeignKey(g => g.EmployeeRequestCode);

            builder.HasQueryFilter(er => er.EntityStateId == (int)Domain.Enums.EntityStates.Active);

            //builder.HasOne<GroupRequest>()
            //    .WithMany(x => x.EmployeeRequests)
            //    .HasForeignKey(x => x.GroupRequestId);

            //builder.HasOne<Period>()
            //    .WithMany(x => x.EmployeeRequests)
            //    .HasForeignKey(x => x.PeriodId);

            //builder.HasOne<Employee>()
            //    .WithMany(x => x.EmployeeRequests)
            //    .HasForeignKey(x => x.EmployeeId);

            //builder.HasOne<RequestStatus>()
            //    .WithMany(x => x.EmployeeRequests)
            //    .HasForeignKey(x => x.RequestStatusId);
        }
    }
}

