using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class AssessmentEvidence
    {
        public int AssessmentId { get; set; }
        public int WorkshopId { get; set; }
        public int ParticipantId { get; set; }
        public bool Completed { get; set; }
    }
}
