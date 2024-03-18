using System.ComponentModel.DataAnnotations.Schema;

namespace MyGoals.Domain.Common
{
    [NotMapped]
    public abstract class DomainEvent
    {
        protected DomainEvent()
        {
            DateOccurred = DateTimeOffset.UtcNow;
        }
        public bool IsPublished { get; set; }
        public DateTimeOffset DateOccurred { get; protected set; } = DateTime.UtcNow;
    }

}

