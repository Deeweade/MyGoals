namespace MyGoals.Domain.Common
{
    public abstract class HistoryEntity : BaseEntity
    {
        public int? Code { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int EntityStateId { get; set; }
    }
}