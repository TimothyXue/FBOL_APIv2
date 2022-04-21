using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Course
    {
        public Course()
        {
            OnlineModules = new HashSet<OnlineModule>();
        }

        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string AntaCourseCode { get; set; }
        public int? QualificationId { get; set; }
        public int? SecondaryQualificationId { get; set; }
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
        public string TpPdfHoursText { get; set; }
        public int? XLlnId { get; set; }
        public bool? IsPartial { get; set; }
        public bool? ExpiredQual { get; set; }

        public virtual ICollection<OnlineModule> OnlineModules { get; set; }
    }
}
