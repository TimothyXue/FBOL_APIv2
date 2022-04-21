using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Element
    {
        public Element()
        {
            PerformanceCriteria = new HashSet<PerformanceCriterion>();
        }

        public int ElementId { get; set; }
        public int FmiUnitId { get; set; }
        public string ElementTitle { get; set; }
        public string ElementRef { get; set; }
        public string ElementRange { get; set; }

        public virtual FmiUnit FmiUnit { get; set; }
        public virtual ICollection<PerformanceCriterion> PerformanceCriteria { get; set; }
    }
}
