using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticpantsByPcompLocationVsProgLocation
    {
        public string FundingType { get; set; }
        public int PrimaryQual { get; set; }
        public DateTime? OverviewDate { get; set; }
        public string CourseName { get; set; }
        public string AntaCourseCode { get; set; }
        public int? ParticipantId { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string ProgramTableLocationName { get; set; }
        public string Address { get; set; }
        public string StateCode { get; set; }
        public int? PcLocationId { get; set; }
        public string PcLocationName { get; set; }
        public string PcLocationStateCode { get; set; }
        public string ReportTo { get; set; }
        public int? QualificationId { get; set; }
        public int? ProgramLocationId { get; set; }
        public string ProgramlocationLocationName { get; set; }
        public string ProgramlocationStatecode { get; set; }
        public int ProgramId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? PartCompId { get; set; }
    }
}
