using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CompetencyLog
    {
        public int CompetencyLogId { get; set; }
        public int ParticipantId { get; set; }
        public string Section { get; set; }
        public string OtherEvidence { get; set; }
    }
}
