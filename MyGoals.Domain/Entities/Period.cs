using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class Period : BaseEntity
    {
        public string? Name { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? YearNumber { get; set; }
        public int? QuarterNumber { get; set; }

        public virtual ICollection<Goal>? Goals { get; set; }
        public virtual ICollection<EmployeeRequest>? EmployeeRequests { get; set; }
    }
}