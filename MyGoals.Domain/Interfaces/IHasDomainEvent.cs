using MyGoals.Domain.Common;

namespace MyGoals.Domain.Interfaces
{
    public interface IHasDomainEvent
    {
        List<DomainEvent> DomainEvents { get; set; }
    }

}

