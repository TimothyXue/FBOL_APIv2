using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActionStep
    {
        public int GoalId { get; set; }
        public int StepOrder { get; set; }
        public string ActionsStep { get; set; }
        public DateTime? TargetDate { get; set; }
        public DateTime? ReviewedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
