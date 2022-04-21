using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Kpi
    {
        public Kpi()
        {
            PerformanceReviewKpis = new HashSet<PerformanceReviewKpi>();
        }

        public int KpiId { get; set; }
        public int ParticipantId { get; set; }
        public string Name { get; set; }
        public string Nature { get; set; }
        public string Definition { get; set; }
        public string Measurement { get; set; }
        public string Performance { get; set; }
        public bool Archived { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public virtual Participant Participant { get; set; }
        public virtual ICollection<PerformanceReviewKpi> PerformanceReviewKpis { get; set; }
    }
}
