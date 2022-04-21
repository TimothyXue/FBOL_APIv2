using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ParticipantPdpBackup
    {
        public int? ParticipantId { get; set; }
        public int? ProgramId { get; set; }
        public int UserId { get; set; }
        public string CertificationReason { get; set; }
        public DateTime? PreCourseDate { get; set; }
        public decimal? AgreedRate { get; set; }
        public byte? ReviewMcr { get; set; }
        public byte? ReviewPcr { get; set; }
        public bool? Discontinued { get; set; }
        public string EnrolmentType { get; set; }
        public DateTime? WelcomeEmailDate { get; set; }
        public string Notes { get; set; }
        public bool? Flm5Enabled { get; set; }
        public DateTime? MeetingDate { get; set; }
        public DateTime? ReviewDate { get; set; }
        public bool? ContactDetailsConfirmed { get; set; }
        public int? Paper { get; set; }
        public DateTime? CertificateIssued { get; set; }
        public Guid Passport { get; set; }
        public string PotwUser { get; set; }
        public string PotwPassword { get; set; }
        public DateTime? PotwAttempted { get; set; }
        public bool? Graduated { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public DateTime? Paid { get; set; }
        public bool? PdpImport { get; set; }
        public bool? TeamViewCreated1 { get; set; }
        public DateTime? TeamViewClose1 { get; set; }
        public bool? TeamViewCreated2 { get; set; }
        public DateTime? TeamViewClose2 { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public int? RelatedParticipantId { get; set; }
        public bool? FundingHold { get; set; }
    }
}
