using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class GoalType : BaseEntity
    {
        public GoalType()
        {
            Goals = new HashSet<Goal>();
            TypicalGoals = new HashSet<TypicalGoal>();
        }

        public string Name { get; set; }

        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<TypicalGoal> TypicalGoals { get; set; }
    }
}