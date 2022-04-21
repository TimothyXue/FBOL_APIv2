﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EnrolmentForm
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneMobile { get; set; }
        public string UniqueStudentIdentifier { get; set; }
        public string PostalBuildingName { get; set; }
        public string PostalUnitDetails { get; set; }
        public string PostalStreetNumber { get; set; }
        public string PostalStreetName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string PostalPostcode { get; set; }
        public string PoBox { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Country { get; set; }
        public short? CountryCode { get; set; }
        public string CityTownBornIn { get; set; }
        public string Language { get; set; }
        public short? LanguageCode { get; set; }
        public short? Proficiency { get; set; }
        public string Indigeneous { get; set; }
        public string ResidentialBuildingName { get; set; }
        public string ResidentialUnitDetails { get; set; }
        public string ResidentialStreetNumber { get; set; }
        public string ResidentialStreetName { get; set; }
        public string Location { get; set; }
        public string ResidentialState { get; set; }
        public string Postcode { get; set; }
        public bool? Disable { get; set; }
        public bool? DisabilityHearing { get; set; }
        public bool? DisabilityPhysical { get; set; }
        public bool? DisabilityIntellectual { get; set; }
        public bool? DisabilityLearning { get; set; }
        public bool? DisabilityMental { get; set; }
        public bool? DisabilityAbi { get; set; }
        public bool? DisabilityVision { get; set; }
        public bool? DisabilityMedical { get; set; }
        public bool? DisabilityOther { get; set; }
        public bool? AtSchool { get; set; }
        public string HighestSchool { get; set; }
        public string YearHighestSchool { get; set; }
        public bool? PriorEducation { get; set; }
        public byte? Degree { get; set; }
        public byte? AdvDiploma { get; set; }
        public byte? Diploma { get; set; }
        public byte? CertIv { get; set; }
        public byte? CertIii { get; set; }
        public byte? CertIi { get; set; }
        public byte? CertI { get; set; }
        public byte? CertOther { get; set; }
        public string LabourForceStatus { get; set; }
        public string StudyReason { get; set; }
        public DateTime? RecordCreated { get; set; }
        public DateTime? Reported { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? ProgramId { get; set; }
        public int? CourseId { get; set; }
        public string VictorianStudentNumber { get; set; }
        public string ApprenticeshipsTci { get; set; }
        public string ApprenticeshipsCi { get; set; }
        public int? Eligibility { get; set; }
        public DateTime? McrReported { get; set; }
        public DateTime? CompReported { get; set; }
        public DateTime? CertReported { get; set; }
        public bool? EnglishAssistance { get; set; }
        public string EnglishAssistanceComments { get; set; }
        public bool? DisabilityAssistance { get; set; }
        public string DisabilityAssistanceComments { get; set; }
        public string DegreeTitle { get; set; }
        public string AdvDiplomaTitle { get; set; }
        public string DiplomaTitle { get; set; }
        public string CertIvTitle { get; set; }
        public string CertIiiTitle { get; set; }
        public string CertIiTitle { get; set; }
        public string CertITitle { get; set; }
        public string CertOtherTitle { get; set; }
        public bool? Support { get; set; }
        public string SupportComments { get; set; }
        public string Rpl { get; set; }
        public string CreditTransfer { get; set; }
        public bool? DetailsCorrect { get; set; }
        public bool? QualsCorrect { get; set; }
        public bool? PrivacyAgreement { get; set; }
        public bool? FundingExplained { get; set; }
        public DateTime? EligibilityApproved { get; set; }
        public string AdminComments { get; set; }
        public DateTime? CompletionsReport { get; set; }
        public string S4aNumber { get; set; }
        public string TrainingContractNumber { get; set; }
        public bool? WorkSa { get; set; }
        public string EmployerSuburb { get; set; }
        public string EmployerPostcode { get; set; }
        public short? ResidentType { get; set; }
        public DateTime? FormCompleted { get; set; }
        public string CourseSiteId { get; set; }
        public int? TraineeshipQual { get; set; }
        public bool? NoSchoolTraining { get; set; }
        public string School { get; set; }
        public string Rto { get; set; }
        public short? IndustryStartYear { get; set; }
        public string AnzscoCode { get; set; }
        public DateTime? CdfDate { get; set; }
        public DateTime? SffDate { get; set; }
        public string ComplianceNotes { get; set; }
        public string TrsNumber { get; set; }
        public DateTime? QualCompletionDate { get; set; }
        public DateTime? SecQualCompletionDate { get; set; }
        public DateTime? QualCancellationDate { get; set; }
        public DateTime? SecQualCancellationDate { get; set; }
        public bool? CertIiiFromHighSchool { get; set; }
        public bool? CurrentlyEnrolledEducation { get; set; }
        public string CurrentlyEnrolledDegreeTitle { get; set; }
        public string CurrentlyEnrolledAdvDiplomaTitle { get; set; }
        public string CurrentlyEnrolledDiplomaTitle { get; set; }
        public string CurrentlyEnrolledCertIvTitle { get; set; }
        public string CurrentlyEnrolledCertIiiTitle { get; set; }
        public string CurrentlyEnrolledCertIiTitle { get; set; }
        public string CurrentlyEnrolledCertITitle { get; set; }
        public string CurrentlyEnrolledCertOtherTitle { get; set; }
        public bool? CertIiiGuaranteeAgreed { get; set; }
        public bool? TrainingEmploymentSurveyAgreed { get; set; }
        public bool? CertIiiGuaranteeSheetRead { get; set; }
        public string IndustryCode { get; set; }
        public string NswCommitmentId { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? NomCompletionDate { get; set; }
        public string FundingEligibilityKey { get; set; }
        public bool? HaveReadVetNotice { get; set; }
        public bool? LlnOk { get; set; }
        public bool? CourseSuitable { get; set; }
        public DateTime? LlnOkDate { get; set; }
        public int? LlnOkUserId { get; set; }
        public DateTime? CourseSuitableDate { get; set; }
        public int? CourseSuitableUserId { get; set; }
        public DateTime? PtrCompleted { get; set; }
        public DateTime? EnrolmentAccepted { get; set; }
        public DateTime? LlnInadequateReviewReminderEmail { get; set; }
        public DateTime? CourseSuitabilityReviewReminderEmail { get; set; }
        public bool? UsiLocateConsent { get; set; }
        public DateTime? NswSsContactDetailsProvided { get; set; }
        public bool? ConcessionHealthCare { get; set; }
        public bool? ConcessionPensioner { get; set; }
        public bool? ConcessionVeteransGold { get; set; }
        public bool? DoNotReport { get; set; }
        public string EmailPrimary { get; set; }
        public string EmailSecondary { get; set; }
        public string SurveyContactStatus { get; set; }
        public DateTime? CourseBrochureAccessDate { get; set; }
        public DateTime? FundingInformationAccessDate { get; set; }
        public DateTime? CodeOfPracticeAccessDate { get; set; }
        public DateTime? InformedReFutureImpact { get; set; }
        public DateTime? AgreeWithAccessConditions { get; set; }
        public bool? IncludeInNatFilesIfNoTp { get; set; }
        public int? FundingSourceNationalIdentifier { get; set; }
        public string OtherCountries { get; set; }
    }
}