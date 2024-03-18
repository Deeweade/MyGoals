using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class BusinessProcessStage : BaseEntity
    {
        public BusinessProcessStage()
        {
            RequestStatuses = new HashSet<RequestStatus>();
        }

        public string Name { get; set; }
        public int? BusinessProcessId { get; set; }

        public virtual BusinessProcess BusinessProcess { get; set; }

        public virtual ICollection<RequestStatus> RequestStatuses { get; set; }
    }

}