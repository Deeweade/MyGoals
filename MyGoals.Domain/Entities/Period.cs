using System.Runtime.CompilerServices;
using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class Period : BaseEntity
    {
        public Period()
        {
            Goals = new HashSet<Goal>();
            EmployeeRequests = new HashSet<EmployeeRequest>();
        }

        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int YearNumber { get; set; }
        public int QuarterNumber { get; set; }

        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<EmployeeRequest> EmployeeRequests { get; set; }
    }
}