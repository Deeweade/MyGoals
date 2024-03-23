using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class RequestStatus : BaseEntity
    {
        public RequestStatus()
        {
            this.RequestStatusOrders = new HashSet<RequestStatusesOrder>();
            this.RequestStatusTransitions = new HashSet<RequestStatusTransition>();
            this.EmployeeRequests = new HashSet<EmployeeRequest>();
        }

        public int? GoalOwnershipTypeId { get; set; }
        public int? BusinessProcessStageId { get; set; }
        public int? ResponsibleRoleId { get; set; }

        public virtual GoalOwnershipType? GoalOwnershipType { get; set; }
        public virtual BusinessProcessStage? BusinessProcessStage { get; set; }
        public virtual EmployeeRole? ResponsibleRole { get; set; }

        public virtual ICollection<RequestStatusesOrder>? RequestStatusOrders { get; set; }
        public virtual ICollection<RequestStatusTransition>? RequestStatusTransitions { get; set; }
        public virtual ICollection<EmployeeRequest>? EmployeeRequests { get; set; }
    }

}