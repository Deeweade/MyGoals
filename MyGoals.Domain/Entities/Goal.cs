using MyGoals.Domain.Interfaces;
using MyGoals.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace MyGoals.Domain.Entities
{
    public class Goal : HistoryEntity, IHasDomainEvent
    {
        public Goal()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }
        public decimal? Weight { get; set; }
        public decimal? PlanValue { get; set; }
        public decimal? FactValue { get; set; }
        public decimal? SelfFactValue { get; set; }
        public int? ParentGoalCode { get; set; }
        public string JiraEpicLink { get; set; }
        public string JiraGantLink { get; set; }
        public bool? IsHidden { get; set; }

        public int? GoalTypeId { get; set; }
        public int? KeyResultTypeId { get; set; }
        public int? EmployeeId { get; set; }
        public int? PeriodId { get; set; }
        public int? TypicalGoalId { get; set; }
        public int? EmployeeRequestCode { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();

        public virtual Employee Employee { get; set; }
        public virtual GoalType GoalType { get; set; }
        public virtual Period Period { get; set; }
        public virtual KeyResultType KeyResultType { get; set; }
        //[ForeignKey("EmployeeRequestCode")]
        //[InverseProperty("Goals")]
        public virtual EmployeeRequest EmployeeRequest { get; set; }
        public virtual TypicalGoal TypicalGoal { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public bool Equals(Goal goal)
        {
            if (goal is null) throw new ArgumentNullException(nameof(goal));

            return this.Code == goal.Code
                && this.Title.Equals(goal.Title)
                && this.ParentGoalCode == goal.ParentGoalCode
                && this.EmployeeRequestCode == goal.EmployeeRequestCode
                && this.GoalTypeId == goal.GoalTypeId
                && this.KeyResultTypeId == goal.KeyResultTypeId
                && this.EmployeeId == goal.EmployeeId
                && this.PeriodId == goal.PeriodId
                && this.Weight == goal.Weight
                && this.PlanValue == goal.PlanValue
                && this.FactValue == goal.FactValue
                && this.SelfFactValue == goal.SelfFactValue
                && this.JiraEpicLink == goal.JiraEpicLink
                && this.JiraGantLink == goal.JiraGantLink;
        }

    }
}
