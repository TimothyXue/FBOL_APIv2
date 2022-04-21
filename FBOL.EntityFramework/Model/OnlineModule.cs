using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class OnlineModule
    {
        public int OnlineModuleId { get; set; }
        public string Module { get; set; }
        public string ModuleTitle { get; set; }
        public string Duration { get; set; }
        public int CourseId { get; set; }
        public int? FmiUnitId { get; set; }
        public int? LessonId { get; set; }
        public int OnlineCourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual FmiUnit FmiUnit { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual OnlineCourse OnlineCourse { get; set; }
    }
}
