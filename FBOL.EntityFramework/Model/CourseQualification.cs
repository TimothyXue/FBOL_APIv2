using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CourseQualification
    {
        public int IsPrimaryQual { get; set; }
        public int QualificationId { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string AntaCourseCode { get; set; }
        public bool? Archived { get; set; }
        public bool? OnlineCourse { get; set; }
        public bool? WwDisabled { get; set; }
        public bool? McrDisabled { get; set; }
        public bool? PcrDisabled { get; set; }
        public bool? TableBooking { get; set; }
        public int? Seq { get; set; }
        public string Request { get; set; }
        public string Version { get; set; }
        public bool? Fbol { get; set; }
        public bool? Dias { get; set; }
        public string CertType { get; set; }
        public int? FacFee1 { get; set; }
        public int? FacFee2 { get; set; }
        public int? FacFee3 { get; set; }
        public int? PartFirstPay { get; set; }
        public int? PartSecondPay { get; set; }
        public bool? NoCoach { get; set; }
        public int? ReplacedBy { get; set; }
        public int? RrpPrice { get; set; }
        public int? CaapPrice { get; set; }
        public int? Platform { get; set; }
        public bool? TeamView { get; set; }
        public int? PdpLessonId { get; set; }
        public bool? CourseProject { get; set; }
        public int? EventTypeId { get; set; }
        public int? CurrentMappingId { get; set; }
        public int? CurrentAlVersion { get; set; }
        public double? CreditUnits { get; set; }
        public bool? PgDisabled { get; set; }
        public int? QualificationLevel { get; set; }
        public short? LeadFromAlVersion { get; set; }
        public string VtgTuitionFeeHour { get; set; }
        public string VtgTuitionFeeHourDual { get; set; }
        public int? BrandingId { get; set; }
        public bool? DualQualifications { get; set; }
        public int? ResourceFee { get; set; }
        public string NswCommitmentId { get; set; }
        public string CourseDuration { get; set; }
        public string TuitionFee { get; set; }
        public string CourseBrochure { get; set; }
        public string CourseBrochureDual { get; set; }
        public decimal? Push { get; set; }
        public decimal? PushDualQual { get; set; }
        public string Expr2 { get; set; }
        public short? QualLevel { get; set; }
        public string QualCode { get; set; }
        public string QualLevelTitle { get; set; }
        public string QualTitle { get; set; }
        public string NominalHoursVic { get; set; }
        public string NominalHoursQld { get; set; }
        public string NominalHoursNsw { get; set; }
        public string NominalHoursSa { get; set; }
        public string NominalHoursWa { get; set; }
        public string NominalHoursTas { get; set; }
        public string NominalHoursAct { get; set; }
        public string NominalHoursNt { get; set; }
        public string LoeIdentifier { get; set; }
        public string FoeIdentifier { get; set; }
        public string AnzscoIdentifier { get; set; }
        public string CpsNumber { get; set; }
        public string NextQualLevel { get; set; }
        public string QualStatus { get; set; }
        public string GovtContribution { get; set; }
    }
}
