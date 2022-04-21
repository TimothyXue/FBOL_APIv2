using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ParticipantCompetencyTemp2
    {
        public int PartCompId { get; set; }
        public int? FundingTypeId { get; set; }
        public string StateCode { get; set; }
        public DateTime? EvidenceDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ProposedEndDate { get; set; }
        public DateTime? PreviousStartDate { get; set; }
        public DateTime? PreviousEndDate { get; set; }
        public DateTime? CurrentStartDate { get; set; }
        public DateTime? EndDateExtended { get; set; }
        public DateTime? CurrentEndDate { get; set; }
    }
}
