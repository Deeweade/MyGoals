using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class EmployeeRole : BaseEntity
    {
        public EmployeeRole()
        {
            this.RequestStatuses = new HashSet<RequestStatus>();
        }

        public string Title { get; set; }

        public virtual ICollection<RequestStatus> RequestStatuses { get; set; }
    }

}