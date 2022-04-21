using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PerformanceCriterion
    {
        public PerformanceCriterion()
        {
            ActivityMatrices = new HashSet<ActivityMatrix>();
            AssessmentMatrices = new HashSet<AssessmentMatrix>();
        }

        public int PerformanceCriteriaId { get; set; }
        public int ElementId { get; set; }
        public string PerformanceCriteriaDesc { get; set; }
        public string PerformanceCriteriaRef { get; set; }
        public string PerformanceCriteriaRange { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Element Element { get; set; }
        public virtual ICollection<ActivityMatrix> ActivityMatrices { get; set; }
        public virtual ICollection<AssessmentMatrix> AssessmentMatrices { get; set; }
    }
}
