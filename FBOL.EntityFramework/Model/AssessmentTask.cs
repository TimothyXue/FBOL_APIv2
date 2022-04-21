using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class AssessmentTask
    {
        public int AssessmentId { get; set; }
        public string AssessmentTitle { get; set; }
        public int LessonId { get; set; }
        public int? Seq { get; set; }
    }
}
