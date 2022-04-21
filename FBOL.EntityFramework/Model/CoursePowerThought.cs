using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CoursePowerThought
    {
        public int PtCourseId { get; set; }
        public int PtId { get; set; }
        public int CourseId { get; set; }
        public int LessonId { get; set; }
    }
}
