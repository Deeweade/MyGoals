using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class RequestStatusTransition : BaseEntity
    {
        public int? GroupRequestId { get; set; }
        public int? SourceStatusId { get; set; }
        public int? NextStatusId { get; set; }
        public string Name { get; set; }

        public virtual GroupRequest? GroupRequest { get; set; }
        public virtual RequestStatus? SourceStatus { get; set; }
    }

}