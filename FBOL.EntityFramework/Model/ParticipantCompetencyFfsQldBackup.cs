using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ParticipantCompetencyFfsQldBackup
    {
        public int PartCompId { get; set; }
        public int ParticipantId { get; set; }
        public int FmiUnitId { get; set; }
        public int QualificationId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ProposedEndDate { get; set; }
        public string TpComments { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CtRplStatus { get; set; }
        public DateTime? CtRplDate { get; set; }
        public DateTime? FundingReported { get; set; }
        public DateTime? PreviousStartDate { get; set; }
        public DateTime? PreviousEndDate { get; set; }
        public bool? TdwUpdate { get; set; }
        public DateTime? CurrentStartDate { get; set; }
        public short? AttendedHours { get; set; }
        public short? PreviousAttendedHours { get; set; }
        public bool? OverdueUpdate { get; set; }
        public DateTime? EndDateExtended { get; set; }
        public DateTime? CurrentEndDate { get; set; }
        public DateTime? Archived { get; set; }
        public string AchievedBy { get; set; }
        public DateTime? DateAchieved { get; set; }
        public string ClientTuitionFee { get; set; }
        public DateTime? EvidenceDate { get; set; }
        public int? LocationId { get; set; }
        public string CpsNumber { get; set; }
    }
}
