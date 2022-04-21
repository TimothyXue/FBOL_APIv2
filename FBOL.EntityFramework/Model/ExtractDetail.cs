using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ExtractDetail
    {
        public long ExtractDetailId { get; set; }
        public int ExtractHeaderId { get; set; }
        public int UserId { get; set; }
        public int ParticipantId { get; set; }
        public int ProgramId { get; set; }
        public int? AlVersion { get; set; }
        public short? AttendedHours { get; set; }
        public short? MappingId { get; set; }
        public DateTime? OverviewDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public DateTime? ExtendAccess { get; set; }
        public DateTime? MaxWorkshopDate { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public int? LocationId { get; set; }
        public int QualificationId { get; set; }
        public string ApprenticeshipsTci { get; set; }
        public string ApprenticeshipsCi { get; set; }
        public int FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public short? FundingTypeId { get; set; }
        public short? FundingTypeError { get; set; }
        public bool Discontinued { get; set; }
        public DateTime? PctrFundingReported { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public DateTime? EnrolledDate { get; set; }
        public string StudyReason { get; set; }
        public int PartCompId { get; set; }
        public DateTime? PcStartDate { get; set; }
        public DateTime? PcEndDate { get; set; }
        public DateTime? CaDateAchieved { get; set; }
        public DateTime? PcDateAchieved { get; set; }
        public DateTime? RplCreateDate { get; set; }
        public DateTime? PCertificateIssuedDate { get; set; }
        public DateTime? MaxWorkshopDateBeforeGetDateUsed { get; set; }
        public DateTime? CertificateIssuedDate { get; set; }
        public int? TuitionFee { get; set; }
        public long? BookingId { get; set; }
        public string CourseSiteId { get; set; }
        public DateTime? CompReported { get; set; }
        public DateTime? CertReported { get; set; }
        public DateTime? M1Date { get; set; }
        public DateTime? PcEvidenceDate { get; set; }
        public string VettrakId { get; set; }
        public string NswCommitmentId { get; set; }
        public int? NumCompletedAssignments { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
