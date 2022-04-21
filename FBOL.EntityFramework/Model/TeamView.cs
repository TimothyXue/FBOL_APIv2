using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class TeamView
    {
        public int TeamViewId { get; set; }
        public int? MmUserId { get; set; }
        public int? ParticipantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Relationship { get; set; }
        public bool? Completed { get; set; }
        public Guid? Ukey { get; set; }
        public bool? HasReports { get; set; }
        public int? NumberReports { get; set; }
        public int? Stage { get; set; }
        public int? ActivityId { get; set; }
        public byte? Q1 { get; set; }
        public byte? Q2 { get; set; }
        public byte? Q3 { get; set; }
        public byte? Q4 { get; set; }
        public byte? Q5 { get; set; }
        public byte? Q6 { get; set; }
        public byte? Q7 { get; set; }
        public byte? Q8 { get; set; }
        public byte? Q9 { get; set; }
        public byte? Q10 { get; set; }
        public byte? Q11 { get; set; }
        public byte? Q12 { get; set; }
        public byte? Q13 { get; set; }
        public byte? Q14 { get; set; }
        public byte? Q15 { get; set; }
        public byte? Q16 { get; set; }
        public byte? Q17 { get; set; }
        public byte? Q18 { get; set; }
        public byte? Q19 { get; set; }
        public byte? Q20 { get; set; }
        public byte? Q21 { get; set; }
        public byte? Q22 { get; set; }
        public byte? Q23 { get; set; }
        public byte? Q24 { get; set; }
        public byte? Q25 { get; set; }
        public byte? Q26 { get; set; }
        public byte? Q27 { get; set; }
        public byte? Q28 { get; set; }
        public byte? Q29 { get; set; }
        public byte? Q30 { get; set; }
        public byte? Q31 { get; set; }
        public byte? Q32 { get; set; }
        public byte? Q33 { get; set; }
        public byte? Q34 { get; set; }
        public byte? Q35 { get; set; }
        public byte? Q36 { get; set; }
        public byte? Q37 { get; set; }
        public string Url { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
