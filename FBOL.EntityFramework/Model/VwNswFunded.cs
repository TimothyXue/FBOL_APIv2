using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwNswFunded
    {
        public int UserId { get; set; }
        public int ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StateCode { get; set; }
        public string CourseCode { get; set; }
        public int? ProgramId { get; set; }
        public DateTime? Reported { get; set; }
        public DateTime? FirstAchievedDate { get; set; }
        public DateTime? McrReported { get; set; }
        public DateTime? CompetencyCompleted { get; set; }
        public DateTime? CompReported { get; set; }
        public DateTime? CertReported { get; set; }
        public DateTime? OverviewDate { get; set; }
        public DateTime? CertificateIssued { get; set; }
        public bool? Discontinued { get; set; }
        public short? FundingTypeId { get; set; }
        public short? FederalFunding { get; set; }
        public string Status { get; set; }
        public DateTime? DateStatusChanged { get; set; }
    }
}
