using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class GroupRequest : BaseEntity
    {
        public GroupRequest()
        {
            this.RequestStatusOrders = new HashSet<RequestStatusesOrder>();
            this.EmployeeRequests = new HashSet<EmployeeRequest>();
        }

        public string Name { get; set; }
        public int? BonusSchemeId { get; set; }
        public int? BusinessProcessId { get; set; }
        public int? PeriodId { get; set; }

        //public virtual BonusScheme BonusScheme { get; set; }
        public virtual BusinessProcess BusinessProcess { get; set; }
        public virtual Period Period { get; set; }

        public virtual ICollection<EmployeeRequest> EmployeeRequests { get; set; }
        public virtual ICollection<RequestStatusesOrder> RequestStatusOrders { get; set; }
        public virtual ICollection<RequestStatusTransition> RequestStatusTransitions { get; set; }
    }

}