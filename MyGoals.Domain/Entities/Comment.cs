using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class Comment : BaseEntity//, IHasDomainEvent
    {
        public string? Text { get; set; }
        public int? EmployeeId { get; set; }
        public int? GoalCode { get; set; }
        //public int? VisibilityId { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual Goal? Goal { get; set; }
        //public virtual Visibility Visibility { get; set; }
    }

}