using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGoals.Domain.Entities;

namespace MyGoals.Infrastructure.Configurations
{
    internal sealed class EmployeeRequestConfiguration : IEntityTypeConfiguration<EmployeeRequest>
    {
        public void Configure(EntityTypeBuilder<EmployeeRequest> builder)
        {
        //    // Альтернативный ключ для EmployeeRequest
        //    builder.HasAlternateKey(er => new { er.Code, er.EntityStateId });

        //    // Ограничение на значение EntityStateId
        //    //builder.HasCheckConstraint("CK_EmployeeRequest_EntityStateId", "EntityStateId = 1");

        //    //builder.HasMany<Goal>()
        //    //    .WithOne(er => er.EmployeeRequest)
        //    //    .HasForeignKey(x => new { x.Id, x.Code, x.EntityStateId });

        //    builder.HasQueryFilter(er => er.EntityStateId == (int)Domain.Enums.EntityStates.Active);

            builder.HasMany(e => e.Goals)
                .WithOne(g => g.EmployeeRequest)
                .HasForeignKey(g => g.EmployeeRequestCode)
                .HasPrincipalKey(e => e.Code)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

