using MyGoals.Domain.Common;
using MyGoals.Domain.Interfaces;

namespace MyGoals.Domain.Entities
{
    public class Comment : BaseEntity, IHasDomainEvent
    {
        public Comment()
        {
            this.DomainEvents = new List<DomainEvent>();
        }

        public string Text { get; set; }
        public int? EmployeeId { get; set; }
        public int? GoalCode { get; set; }
        //public int? VisibilityId { get; set; }

        public List<DomainEvent> DomainEvents { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Goal Goal { get; set; }
        //public virtual Visibility Visibility { get; set; }
    }

}