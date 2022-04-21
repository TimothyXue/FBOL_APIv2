using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VActivityLesson
    {
        public int ActivityId { get; set; }
        public int LessonId { get; set; }
        public string Module { get; set; }
        public string ActivityTitle { get; set; }
        public int? LiveId { get; set; }
        public string Live { get; set; }
        public int? ReviewId { get; set; }
        public string Review { get; set; }
        public int? SubmitId { get; set; }
        public string Submit { get; set; }
        public int? Seq { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public int LessonSeq { get; set; }
    }
}
