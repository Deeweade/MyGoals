using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class RequestStatusesOrder : BaseEntity
    {
        public int? GroupRequestId { get; set; }
        public int? RequestStatusId { get; set; }
        public int? StatusOrder { get; set; }

        public virtual GroupRequest? GroupRequest { get; set; }
        public virtual RequestStatus? RequestStatus { get; set; }
    }

}