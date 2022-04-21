using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwPartCompPrimaryQualRow
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public int ProgramId { get; set; }
        public DateTime? OverviewDate { get; set; }
        public int ParticipantId { get; set; }
        public int FmiUnitId { get; set; }
        public string QualificationFlag { get; set; }
        public int QualificationId { get; set; }
        public int PartCompId { get; set; }
        public DateTime? Archived { get; set; }
        public int UserId { get; set; }
    }
}
