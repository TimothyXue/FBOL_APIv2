using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwCourseToActivityKeep
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public short? MappingId { get; set; }
        public int? AlVersion { get; set; }
        public string LessonName { get; set; }
        public int ActivityId { get; set; }
        public string ActivityTitle { get; set; }
        public int LessonSeq { get; set; }
        public string Version { get; set; }
        public int WorkshopId { get; set; }
        public DateTime? WorkshopDate { get; set; }
        public int ProgramId { get; set; }
        public int LessonId { get; set; }
        public int QualificationId { get; set; }
        public int ParticipantId { get; set; }
    }
}
