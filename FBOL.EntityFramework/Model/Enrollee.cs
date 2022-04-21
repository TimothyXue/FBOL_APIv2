using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Enrollee
    {
        public int EnrolleeId { get; set; }
        public int ProgramId { get; set; }
        public int? UserId { get; set; }
        public int? ParticipantId { get; set; }
        public int Priority { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string MmFirstName { get; set; }
        public string MmLastName { get; set; }
        public string MmCompany { get; set; }
        public string MmEmail { get; set; }
        public string CoachFirstName { get; set; }
        public string CoachLastName { get; set; }
        public string CoachEmail { get; set; }
        public int LicenseeId { get; set; }
        public DateTime EnrolledDate { get; set; }
        public string EnrolmentType { get; set; }
        public DateTime? CommencementDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public string Notes { get; set; }
        public string FormerLastName { get; set; }
        public int? CompanyHistoryId { get; set; }
        public int? CoachId { get; set; }
        public bool? AllowToEnrol { get; set; }
        public int? SaleTypeId { get; set; }
        public short? FundingTypeId { get; set; }
        public short? FederalFunding { get; set; }
        public short? FundingTypeError { get; set; }
        public string SalesPerson { get; set; }
        public int? SalePrice { get; set; }
        public bool? NewAccount { get; set; }
        public int? XxxcatscanLicenseId { get; set; }
        public int? OldLicenseeId { get; set; }
        public bool? PerfPack { get; set; }
        public string CoursePart { get; set; }
        public long? BookingId { get; set; }
        public int? TuitionFee { get; set; }
        public string QualificationFlag { get; set; }
        public int? CompanyNameId { get; set; }
        public string IndustryCode { get; set; }
        public int? FacInvoiceLicenseeId { get; set; }
        public DateTime? UpgradeToFullQual { get; set; }
        public int? CourseResourceFeeOverride { get; set; }
        public int? CourseResourceFeeOverrideSecondary { get; set; }
        public decimal? Push { get; set; }
        public string TuitionFeeHourOverride { get; set; }
        public int? UnitSignoffMm1Obsvr2ElseNull { get; set; }
        public string VettrakId { get; set; }
        public DateTime? NominatedWelcomeEmail { get; set; }
        public DateTime? DateGivenCertIfNotGrad { get; set; }
        public bool? TrainingOccursAtWorkplace { get; set; }
        public int? OverrideLocationId { get; set; }
        public int? ReportTo { get; set; }
        public bool? IsVirtual { get; set; }
        public int? RefUserId { get; set; }
        public bool? BacWageSubsidy { get; set; }
        public int? GovtContributionOverride { get; set; }

        public virtual Program Program { get; set; }
    }
}
