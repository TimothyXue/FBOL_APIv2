using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PerformanceReviewKpi
    {
        public int PrKpiId { get; set; }
        public int KpiId { get; set; }
        public int? PerformanceReviewId { get; set; }
        public string NaturePr { get; set; }
        public int? Rating { get; set; }
        public string Comment { get; set; }

        public virtual Kpi Kpi { get; set; }
    }
}
