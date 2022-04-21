using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingParticipantStatus
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseCode { get; set; }
        public DateTime? OverviewDate { get; set; }
        public string LocationName { get; set; }
        public string FundingType { get; set; }
        public bool? Discontinued { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public DateTime? Reported { get; set; }
        public int? UserId { get; set; }
        public int? ParticipantId { get; set; }
    }
}
