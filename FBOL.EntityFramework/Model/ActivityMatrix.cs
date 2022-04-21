using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActivityMatrix
    {
        public int PerformanceCriteriaId { get; set; }
        public int ActivityId { get; set; }
        public int CourseId { get; set; }
        public short MappingId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual PerformanceCriterion PerformanceCriteria { get; set; }
    }
}
