using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwPartCompDatesAllPlugInPartId
    {
        public string CourseCode { get; set; }
        public DateTime? OverviewDate { get; set; }
        public int ProgramId { get; set; }
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public int PartCompId { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CurrentEndDate { get; set; }
        public DateTime? EndDateExtended { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CurrentStartDate { get; set; }
        public short? AttendedHours { get; set; }
        public int FmiUnitId { get; set; }
        public DateTime? DateAchieved { get; set; }
        public string FmiUnitCode { get; set; }
        public DateTime? EvidenceDate { get; set; }
        public DateTime? PreviousEndDate { get; set; }
        public DateTime? ProposedEndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? GraduationDate { get; set; }
    }
}
