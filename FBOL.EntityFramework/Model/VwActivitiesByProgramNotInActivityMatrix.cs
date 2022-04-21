using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwActivitiesByProgramNotInActivityMatrix
    {
        public int ActivityId { get; set; }
        public int ProgramId { get; set; }
        public int? NullActivityId { get; set; }
        public string LessonName { get; set; }
        public int LessonId { get; set; }
        public int LessonSeq { get; set; }
        public int? Seq { get; set; }
    }
}
