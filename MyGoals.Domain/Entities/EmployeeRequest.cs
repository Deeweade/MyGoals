using System.ComponentModel.DataAnnotations.Schema;
using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class EmployeeRequest : HistoryEntity
    {
        public int? GroupRequestId { get; set; }
        public int? EmployeeId { get; set; }
        public int? RequestStatusId { get; set; }
        public int? ResponsibleEmployeeId { get; set; }
        public int? PeriodId { get; set; }

        public virtual GroupRequest? GroupRequest { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual RequestStatus? RequestStatus { get; set; }
        public virtual Period? Period { get; set; }

        public virtual ICollection<Goal>? Goals { get; set; }
    }
}