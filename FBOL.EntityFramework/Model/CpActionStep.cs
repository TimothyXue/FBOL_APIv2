using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CpActionStep
    {
        public long StepId { get; set; }
        public int ParticipantId { get; set; }
        public string ActionStep { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TargetDate { get; set; }
        public string AssignedTo { get; set; }
        public string Stakeholders { get; set; }
        public DateTime? CompleteDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
