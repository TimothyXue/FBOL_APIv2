using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PerformanceReview
    {
        public int PerformanceReviewId { get; set; }
        public int? ParticipantId { get; set; }
        public DateTime? DateArchived { get; set; }
        public Guid? ArchivedId { get; set; }
        public int? MmId { get; set; }
        public bool? Combined { get; set; }
        public DateTime? ReviewDate { get; set; }
        public DateTime? Created { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Q5 { get; set; }
        public string Q6 { get; set; }
        public string Q7 { get; set; }
        public string Q8 { get; set; }
        public string Q9 { get; set; }
        public string Q10 { get; set; }
        public string Q11 { get; set; }
        public string Q12 { get; set; }
        public int? Q13a { get; set; }
        public int? Q13b { get; set; }
        public int? Q13c { get; set; }
        public string Q14 { get; set; }
        public string Q15 { get; set; }
        public string Q16 { get; set; }
    }
}
