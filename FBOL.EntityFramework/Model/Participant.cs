using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Participant
    {
        public Participant()
        {
            ActivityComments = new HashSet<ActivityComment>();
            ActivityDetails = new HashSet<ActivityDetail>();
            DailyWins = new HashSet<DailyWin>();
            GeneralComments = new HashSet<GeneralComment>();
            Kpis = new HashSet<Kpi>();
            MasterDreamLists = new HashSet<MasterDreamList>();
            ParticipantAccesses = new HashSet<ParticipantAccess>();
            PositionDescs = new HashSet<PositionDesc>();
            Tools = new HashSet<Tool>();
        }

        public int ParticipantId { get; set; }
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
        public DateTime? FundingHold { get; set; }
        public bool? NoQualification { get; set; }
        public bool? AssessNotAgreed { get; set; }
        public bool? ReceivedCourseMaterial { get; set; }
        public DateTime? CourseExpiry { get; set; }
        public DateTime? ExtendAccess { get; set; }
        public int? LocationId { get; set; }
        public DateTime? CertificatePending { get; set; }
        public int? OldParticipantId { get; set; }
        public DateTime? PaymentCompleted { get; set; }
        public string PeerReviewedActivityIds { get; set; }
        public bool? ReviewedCourseBrochure { get; set; }
        public bool? ReviewedFundingInformation { get; set; }
        public string FundingInformationHtml { get; set; }
        public DateTime? Confirmed1 { get; set; }
        public DateTime? Confirmed2 { get; set; }
        public bool? ViewedCodeOfPractice { get; set; }
        public short StatusNow { get; set; }
        public bool? UnderstandAmNonAccredited { get; set; }
        public bool? UnderstandNoSoa { get; set; }
        public bool? ExpiredQualAgreed { get; set; }

        public virtual Suitability Suitability { get; set; }
        public virtual ICollection<ActivityComment> ActivityComments { get; set; }
        public virtual ICollection<ActivityDetail> ActivityDetails { get; set; }
        public virtual ICollection<DailyWin> DailyWins { get; set; }
        public virtual ICollection<GeneralComment> GeneralComments { get; set; }
        public virtual ICollection<Kpi> Kpis { get; set; }
        public virtual ICollection<MasterDreamList> MasterDreamLists { get; set; }
        public virtual ICollection<ParticipantAccess> ParticipantAccesses { get; set; }
        public virtual ICollection<PositionDesc> PositionDescs { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
    }
}
