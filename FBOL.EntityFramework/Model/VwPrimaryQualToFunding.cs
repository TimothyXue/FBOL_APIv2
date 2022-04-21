using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwPrimaryQualToFunding
    {
        public int UserId { get; set; }
        public int ParticipantId { get; set; }
        public int? ProgramId { get; set; }
        public DateTime? OverviewDate { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public int IsPrimary { get; set; }
        public int QualificationId { get; set; }
        public string AntaCourseCode { get; set; }
        public short FundingTypeId { get; set; }
        public string FundingType { get; set; }
        public string FundingTypeAbbr { get; set; }
        public short? FederalFunding { get; set; }
        public string ReportTo { get; set; }
        public string QualificationFlag { get; set; }
        public short? QualLevel { get; set; }
        public bool? Archived { get; set; }
        public bool? CombinedPending { get; set; }
        public bool? DualQualifications { get; set; }
    }
}
