using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class TypicalGoal : BaseEntity
    {
        public TypicalGoal()
        {
            this.Goals = new HashSet<Goal>();
        }

        public string BonusScheme { get; set; }
        public string Title { get; set; }
        public decimal? Weight { get; set; }
        public decimal? PlanValue { get; set; }
        public int? GoalTypeId { get; set; }
        public int? KeyResultTypeId { get; set; }
        public int? ParentTypicalGoalId { get; set; }

        public virtual GoalType? GoalType { get; set; }
        public virtual KeyResultType? KeyResultType { get; set; }

        public virtual ICollection<Goal> Goals { get; set; }
    }

}