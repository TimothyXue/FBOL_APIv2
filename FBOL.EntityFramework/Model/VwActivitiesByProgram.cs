using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwActivitiesByProgram
    {
        public int ActivityId { get; set; }
        public int? ProgramId { get; set; }
        public int LessonSeq { get; set; }
        public string LessonName { get; set; }
        public int LessonId { get; set; }
    }
}
