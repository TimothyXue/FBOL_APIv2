using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class AssessmentMatrix
    {
        public int PerformanceCriteriaId { get; set; }
        public int LessonQuestionId { get; set; }

        public virtual LessonQuestion LessonQuestion { get; set; }
        public virtual PerformanceCriterion PerformanceCriteria { get; set; }
    }
}
