using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwProgramToActivitiesLessonsElementsPerfCriteriaMaster
    {
        public int IsPrimaryQual { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public int LessonCourseId { get; set; }
        public int QualificationId { get; set; }
        public int? ProgramId { get; set; }
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public int FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public int ActivityId { get; set; }
        public string ActivityTitle { get; set; }
        public int ElementId { get; set; }
        public string ElementTitle { get; set; }
        public int PerformanceCriteriaId { get; set; }
        public string PerformanceCriteriaDesc { get; set; }
        public string Version { get; set; }
        public short MappingId { get; set; }
        public int AlVersion { get; set; }
    }
}
