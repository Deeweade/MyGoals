using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class GoalOwnershipType : BaseEntity
    {
        public GoalOwnershipType()
        {
            RequestStatuses = new HashSet<RequestStatus>();
        }

        public string Name { get; set; }

        public virtual ICollection<RequestStatus> RequestStatuses { get; set; }
    }

}