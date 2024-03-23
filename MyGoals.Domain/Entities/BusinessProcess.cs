﻿using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class BusinessProcess : BaseEntity
    {
        public string? Name { get; set; }

        public virtual ICollection<GroupRequest>? GroupRequests { get; set; }
        public virtual ICollection<BusinessProcessStage>? BusinessProcessStages { get; set; }
    }

}