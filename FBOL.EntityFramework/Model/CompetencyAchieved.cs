using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CompetencyAchieved
    {
        public int CompetencyAchievedId { get; set; }
        public DateTime? DateAchieved { get; set; }
        public int? AssessorId { get; set; }
        public int ParticipantId { get; set; }
        public int FmiUnitId { get; set; }
        public bool? Agreed { get; set; }
        public int QualificationId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
