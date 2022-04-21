using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ElementJudgementComment
    {
        public int AssessmentId { get; set; }
        public int? AssessorId { get; set; }
        public int ParticipantId { get; set; }
        public int ElementId { get; set; }
        public string Comments { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
