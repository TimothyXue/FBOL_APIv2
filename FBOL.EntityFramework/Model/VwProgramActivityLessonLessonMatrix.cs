using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwProgramActivityLessonLessonMatrix
    {
        public int CourseId { get; set; }
        public int ProgramId { get; set; }
        public int ActivityId { get; set; }
        public int LessonId { get; set; }
        public int AlVersion { get; set; }
    }
}
