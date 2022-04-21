using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LessonGroup
    {
        public int LessonGroupId { get; set; }
        public int CourseId { get; set; }
        public int GroupId { get; set; }
        public int GroupSeq { get; set; }
        public int LessonId { get; set; }
        public int LessonSeq { get; set; }
    }
}
