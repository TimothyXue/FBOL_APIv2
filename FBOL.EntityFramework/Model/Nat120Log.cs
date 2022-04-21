using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Nat120Log
    {
        public long Nat120LogId { get; set; }
        public int? Nat120Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ParticipantId { get; set; }
        public int? FmiUnitId { get; set; }
        public int? QualificationId { get; set; }
        public int? FundingTypeId { get; set; }
        public string LocationIdentifier { get; set; }
        public int? StudentIdentifier { get; set; }
        public string UnitCompetencyIdentifier { get; set; }
        public string QualCourseIdentifier { get; set; }
        public DateTime? CompetencyStartDate { get; set; }
        public DateTime? CompetencyEndDate { get; set; }
        public string DeliveryModeIdentifier { get; set; }
        public string OutcomeIdentifierNational { get; set; }
        public string ScheduledHours { get; set; }
        public string FundingSourceNational { get; set; }
        public string CommencingCourseIdentifier { get; set; }
        public string TrainingContractIdentifier { get; set; }
        public string ClientIdentifier { get; set; }
        public string StudyReasonIdentifier { get; set; }
        public string VetFlag { get; set; }
        public string OutcomeIdentifierOrganisation { get; set; }
        public string FundingSource { get; set; }
        public string ClientTuitionFee { get; set; }
        public string FeeExemption { get; set; }
        public string PurchasingContractIdentifier { get; set; }
        public string PurchasingContractSchedule { get; set; }
        public string HoursAttended { get; set; }
        public DateTime? CourseCommencementDate { get; set; }
        public string EligibilityExemptionIndicator { get; set; }
        public string VetFeeHelp { get; set; }
        public string IndustryCode { get; set; }
        public DateTime? EnrolmentDate { get; set; }
        public string EnrolmentIdentifier { get; set; }
        public string ClientFeesOther { get; set; }
        public string DeliveryProviderAbn { get; set; }
    }
}
