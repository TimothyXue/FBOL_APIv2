using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Rpl
    {
        public int ParticipantId { get; set; }
        public int FmiUnitId { get; set; }
        public int QualificationId { get; set; }
        public int? AssessorId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? CreditTransfer { get; set; }
        public bool? PositionDesc { get; set; }
        public bool? FormalQual { get; set; }
        public bool? SelfAssessment { get; set; }
        public bool? ThirdPartyRpt { get; set; }
        public bool? WorkSamples { get; set; }
        public bool? InterviewQues { get; set; }
        public bool? Resume { get; set; }
        public bool? Portfolio { get; set; }
        public bool? Demonstration { get; set; }
        public bool? Observation { get; set; }
        public string Comments { get; set; }
        public bool? Agreed { get; set; }
        public bool? AutoAssessed { get; set; }
    }
}
