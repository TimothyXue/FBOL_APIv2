using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwCourseCompWa
    {
        public int QualificationId { get; set; }
        public string QualCode { get; set; }
        public string CourseCode { get; set; }
        public int ProgramId { get; set; }
        public string LessonName { get; set; }
        public DateTime? WorkshopDate { get; set; }
        public int? FacilitatorUserId { get; set; }
        public DateTime? GraduationDate { get; set; }
        public int ActivityId { get; set; }
        public short MappingId { get; set; }
        public int FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public string FmiUnitTitle { get; set; }
        public string FmiUnitDesc { get; set; }
        public int ElementId { get; set; }
        public string ElementTitle { get; set; }
        public string ElementRef { get; set; }
        public string ElementRange { get; set; }
        public int PerformanceCriteriaId { get; set; }
        public string PerformanceCriteriaDesc { get; set; }
        public string PerformanceCriteriaRef { get; set; }
        public string PerformanceCriteriaRange { get; set; }
        public string ActivityTitle { get; set; }
        public string ActivityDesc { get; set; }
        public int AlVersion { get; set; }
        public int CourseId { get; set; }
        public DateTime? OverviewDate { get; set; }
    }
}
