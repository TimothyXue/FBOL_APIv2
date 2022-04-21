using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantCompetencyStartDatesFromNowMinus2Year
    {
        public DateTime? PcToReportStartDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DateAchieved { get; set; }
        public DateTime? RplCreateDate { get; set; }
        public int ParticipantId { get; set; }
        public int PartCompId { get; set; }
        public int FmiUnitId { get; set; }
        public int QualificationId { get; set; }
        public DateTime? FundingReported { get; set; }
    }
}
