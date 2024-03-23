using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class KeyResultType : BaseEntity
    {
        public string? Title { get; set; }

        public virtual ICollection<Goal>? Goals { get; set; }
        public virtual ICollection<TypicalGoal>? TypicalGoals { get; set; }
    }
}