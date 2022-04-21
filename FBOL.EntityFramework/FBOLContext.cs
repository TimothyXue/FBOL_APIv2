using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FBOLContext : DbContext
    {
        public FBOLContext()
        {
        }

        public FBOLContext(DbContextOptions<FBOLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accomplishment> Accomplishments { get; set; }
        public virtual DbSet<ActActivity> ActActivities { get; set; }
        public virtual DbSet<ActionStep> ActionSteps { get; set; }
        public virtual DbSet<ActionStepUser> ActionStepUsers { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityComment> ActivityComments { get; set; }
        public virtual DbSet<ActivityCommentsNz> ActivityCommentsNzs { get; set; }
        public virtual DbSet<ActivityDetail> ActivityDetails { get; set; }
        public virtual DbSet<ActivityDetailNz> ActivityDetailNzs { get; set; }
        public virtual DbSet<ActivityDetailSnapshot> ActivityDetailSnapshots { get; set; }
        public virtual DbSet<ActivityDetailXtra> ActivityDetailXtras { get; set; }
        public virtual DbSet<ActivityIdChangeHistory> ActivityIdChangeHistories { get; set; }
        public virtual DbSet<ActivityLesson> ActivityLessons { get; set; }
        public virtual DbSet<ActivityMatrix> ActivityMatrices { get; set; }
        public virtual DbSet<ActivityNewVersion> ActivityNewVersions { get; set; }
        public virtual DbSet<ActivityReceipt> ActivityReceipts { get; set; }
        public virtual DbSet<AllType> AllTypes { get; set; }
        public virtual DbSet<AllTypeValue> AllTypeValues { get; set; }
        public virtual DbSet<AnzscoCode> AnzscoCodes { get; set; }
        public virtual DbSet<AnzscoCodesAdditional> AnzscoCodesAdditionals { get; set; }
        public virtual DbSet<AssessmentEvidence> AssessmentEvidences { get; set; }
        public virtual DbSet<AssessmentMatrix> AssessmentMatrices { get; set; }
        public virtual DbSet<AssessmentMethod> AssessmentMethods { get; set; }
        public virtual DbSet<AssessmentTask> AssessmentTasks { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceReason> AttendanceReasons { get; set; }
        public virtual DbSet<Auspost> Ausposts { get; set; }
        public virtual DbSet<AvetmissNat00060> AvetmissNat00060s { get; set; }
        public virtual DbSet<AvetmissNat00060Temp> AvetmissNat00060Temps { get; set; }
        public virtual DbSet<BoralParticipant> BoralParticipants { get; set; }
        public virtual DbSet<Branding> Brandings { get; set; }
        public virtual DbSet<Bulletin> Bulletins { get; set; }
        public virtual DbSet<CertificateIssued> CertificateIssueds { get; set; }
        public virtual DbSet<CertificateRegister> CertificateRegisters { get; set; }
        public virtual DbSet<CertificateText> CertificateTexts { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<CoachRecord> CoachRecords { get; set; }
        public virtual DbSet<CoachingRecord> CoachingRecords { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAll> CompanyAlls { get; set; }
        public virtual DbSet<CompanyCatscanv2> CompanyCatscanv2s { get; set; }
        public virtual DbSet<CompetencyAchieved> CompetencyAchieveds { get; set; }
        public virtual DbSet<CompetencyLog> CompetencyLogs { get; set; }
        public virtual DbSet<CompetencyMatrix> CompetencyMatrices { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseCompetency> CourseCompetencies { get; set; }
        public virtual DbSet<CourseEvaluation> CourseEvaluations { get; set; }
        public virtual DbSet<CourseFeePeriod> CourseFeePeriods { get; set; }
        public virtual DbSet<CourseHistory> CourseHistories { get; set; }
        public virtual DbSet<CourseLln> CourseLlns { get; set; }
        public virtual DbSet<CourseMapping> CourseMappings { get; set; }
        public virtual DbSet<CoursePart> CourseParts { get; set; }
        public virtual DbSet<CoursePowerThought> CoursePowerThoughts { get; set; }
        public virtual DbSet<CourseQualification> CourseQualifications { get; set; }
        public virtual DbSet<CpActionStep> CpActionSteps { get; set; }
        public virtual DbSet<CpBudget> CpBudgets { get; set; }
        public virtual DbSet<DailyWin> DailyWins { get; set; }
        public virtual DbSet<DoNotSendA> DoNotSendAs { get; set; }
        public virtual DbSet<DocumentList> DocumentLists { get; set; }
        public virtual DbSet<DownerActivityBook> DownerActivityBooks { get; set; }
        public virtual DbSet<EbookCourseMaterial> EbookCourseMaterials { get; set; }
        public virtual DbSet<EbookCourseMaterialsCustom> EbookCourseMaterialsCustoms { get; set; }
        public virtual DbSet<EbookDownload> EbookDownloads { get; set; }
        public virtual DbSet<EbookDownloadsCustom> EbookDownloadsCustoms { get; set; }
        public virtual DbSet<EfTemp> EfTemps { get; set; }
        public virtual DbSet<Element> Elements { get; set; }
        public virtual DbSet<ElementJudgementComment> ElementJudgementComments { get; set; }
        public virtual DbSet<Eligiblity> Eligiblities { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailFormat> EmailFormats { get; set; }
        public virtual DbSet<EmailLog> EmailLogs { get; set; }
        public virtual DbSet<EmailLogAttach> EmailLogAttaches { get; set; }
        public virtual DbSet<EmailResend> EmailResends { get; set; }
        public virtual DbSet<EmailSubscribe> EmailSubscribes { get; set; }
        public virtual DbSet<EmailUnsubscribe> EmailUnsubscribes { get; set; }
        public virtual DbSet<EmpAddress> EmpAddresses { get; set; }
        public virtual DbSet<Enrollee> Enrollees { get; set; }
        public virtual DbSet<EnrolmentForm> EnrolmentForms { get; set; }
        public virtual DbSet<EnrolmentFormAdditional> EnrolmentFormAdditionals { get; set; }
        public virtual DbSet<EnrolmentFormNz> EnrolmentFormNzs { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<ExpectedEnrolment> ExpectedEnrolments { get; set; }
        public virtual DbSet<ExtractAuditType> ExtractAuditTypes { get; set; }
        public virtual DbSet<ExtractDetail> ExtractDetails { get; set; }
        public virtual DbSet<ExtractExclude> ExtractExcludes { get; set; }
        public virtual DbSet<ExtractHeader> ExtractHeaders { get; set; }
        public virtual DbSet<ExtractTag> ExtractTags { get; set; }
        public virtual DbSet<ExtractTracking> ExtractTrackings { get; set; }
        public virtual DbSet<Facilitator> Facilitators { get; set; }
        public virtual DbSet<FacilitatorComment> FacilitatorComments { get; set; }
        public virtual DbSet<FacilitatorInvoice> FacilitatorInvoices { get; set; }
        public virtual DbSet<FboltoAct> FboltoActs { get; set; }
        public virtual DbSet<FboltoCrm> FboltoCrms { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<FeedbackQuestionResponse> FeedbackQuestionResponses { get; set; }
        public virtual DbSet<FfsOnly> FfsOnlies { get; set; }
        public virtual DbSet<FileNote> FileNotes { get; set; }
        public virtual DbSet<FmiMatrix> FmiMatrices { get; set; }
        public virtual DbSet<FmiReplacement> FmiReplacements { get; set; }
        public virtual DbSet<FmiUnit> FmiUnits { get; set; }
        public virtual DbSet<FmiUnitChangeHistory> FmiUnitChangeHistories { get; set; }
        public virtual DbSet<Funding> Fundings { get; set; }
        public virtual DbSet<FundingAdjustment> FundingAdjustments { get; set; }
        public virtual DbSet<FundingImport> FundingImports { get; set; }
        public virtual DbSet<FundingInvoiceRequest> FundingInvoiceRequests { get; set; }
        public virtual DbSet<FundingInvoiceRequestBackup> FundingInvoiceRequestBackups { get; set; }
        public virtual DbSet<FundingParticipantStatus> FundingParticipantStatuses { get; set; }
        public virtual DbSet<FundingRate> FundingRates { get; set; }
        public virtual DbSet<FundingRatesBackup> FundingRatesBackups { get; set; }
        public virtual DbSet<FundingReceived> FundingReceiveds { get; set; }
        public virtual DbSet<FundingReceivedBackup> FundingReceivedBackups { get; set; }
        public virtual DbSet<FundingReceivedBackupForPeter> FundingReceivedBackupForPeters { get; set; }
        public virtual DbSet<FundingType> FundingTypes { get; set; }
        public virtual DbSet<FundingTypeCourse> FundingTypeCourses { get; set; }
        public virtual DbSet<FundingTypeFederal> FundingTypeFederals { get; set; }
        public virtual DbSet<GeneralComment> GeneralComments { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<GoalUser> GoalUsers { get; set; }
        public virtual DbSet<GraduateConnection> GraduateConnections { get; set; }
        public virtual DbSet<HideActivityByParticipant> HideActivityByParticipants { get; set; }
        public virtual DbSet<HideActivityByProgram> HideActivityByPrograms { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Hpa> Hpas { get; set; }
        public virtual DbSet<ImperativeImportant> ImperativeImportants { get; set; }
        public virtual DbSet<IntroductionLink> IntroductionLinks { get; set; }
        public virtual DbSet<InvoicePayment> InvoicePayments { get; set; }
        public virtual DbSet<Kpi> Kpis { get; set; }
        public virtual DbSet<Lead2004> Lead2004s { get; set; }
        public virtual DbSet<Lead2005list> Lead2005lists { get; set; }
        public virtual DbSet<LeadCourse> LeadCourses { get; set; }
        public virtual DbSet<LeadNomination> LeadNominations { get; set; }
        public virtual DbSet<LeadNominationBackup> LeadNominationBackups { get; set; }
        public virtual DbSet<LearningseatRaw> LearningseatRaws { get; set; }
        public virtual DbSet<LearningseatResult> LearningseatResults { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<LessonEmail> LessonEmails { get; set; }
        public virtual DbSet<LessonGroup> LessonGroups { get; set; }
        public virtual DbSet<LessonQuestion> LessonQuestions { get; set; }
        public virtual DbSet<Licensee> Licensees { get; set; }
        public virtual DbSet<LicenseeAccess> LicenseeAccesses { get; set; }
        public virtual DbSet<LicenseeChange> LicenseeChanges { get; set; }
        public virtual DbSet<LicenseeOld> LicenseeOlds { get; set; }
        public virtual DbSet<LiteracyNumeracy> LiteracyNumeracies { get; set; }
        public virtual DbSet<Lln> Llns { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MailingListImport> MailingListImports { get; set; }
        public virtual DbSet<MajorClient> MajorClients { get; set; }
        public virtual DbSet<MajorClientCourseId> MajorClientCourseIds { get; set; }
        public virtual DbSet<MasterDreamList> MasterDreamLists { get; set; }
        public virtual DbSet<McrPcr> McrPcrs { get; set; }
        public virtual DbSet<McrPcrResult> McrPcrResults { get; set; }
        public virtual DbSet<Nat120Log> Nat120Logs { get; set; }
        public virtual DbSet<Nat120vic> Nat120vics { get; set; }
        public virtual DbSet<Nat120vicLma> Nat120vicLmas { get; set; }
        public virtual DbSet<Nat120vicLma7> Nat120vicLma7s { get; set; }
        public virtual DbSet<Nat120vicTp> Nat120vicTps { get; set; }
        public virtual DbSet<Nat120vicTp7> Nat120vicTp7s { get; set; }
        public virtual DbSet<NominalDuration> NominalDurations { get; set; }
        public virtual DbSet<NswFundedParticipant> NswFundedParticipants { get; set; }
        public virtual DbSet<NswFundedParticipants2015> NswFundedParticipants2015s { get; set; }
        public virtual DbSet<OnlineCourse> OnlineCourses { get; set; }
        public virtual DbSet<OnlineModule> OnlineModules { get; set; }
        public virtual DbSet<PartCompTemp> PartCompTemps { get; set; }
        public virtual DbSet<PartCourse> PartCourses { get; set; }
        public virtual DbSet<PartId> PartIds { get; set; }
        public virtual DbSet<PartIdsExcluded> PartIdsExcludeds { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<ParticipantAccess> ParticipantAccesses { get; set; }
        public virtual DbSet<ParticipantCompetency> ParticipantCompetencies { get; set; }
        public virtual DbSet<ParticipantCompetencyFf> ParticipantCompetencyFfs { get; set; }
        public virtual DbSet<ParticipantCompetencyFfsQldBackup> ParticipantCompetencyFfsQldBackups { get; set; }
        public virtual DbSet<ParticipantCompetencyTemp> ParticipantCompetencyTemps { get; set; }
        public virtual DbSet<ParticipantCompetencyTemp2> ParticipantCompetencyTemp2s { get; set; }
        public virtual DbSet<ParticipantCompetencyTemp3> ParticipantCompetencyTemp3s { get; set; }
        public virtual DbSet<ParticipantCompetencyToReport> ParticipantCompetencyToReports { get; set; }
        public virtual DbSet<ParticipantPdpBackup> ParticipantPdpBackups { get; set; }
        public virtual DbSet<ParticipantQualFunding> ParticipantQualFundings { get; set; }
        public virtual DbSet<ParticipantStatusChange> ParticipantStatusChanges { get; set; }
        public virtual DbSet<ParticipantTransferred> ParticipantTransferreds { get; set; }
        public virtual DbSet<PasswordList> PasswordLists { get; set; }
        public virtual DbSet<Pblog> Pblogs { get; set; }
        public virtual DbSet<PcsReported> PcsReporteds { get; set; }
        public virtual DbSet<PdpReminder> PdpReminders { get; set; }
        public virtual DbSet<PdpTool> PdpTools { get; set; }
        public virtual DbSet<PdpdiasNomination> PdpdiasNominations { get; set; }
        public virtual DbSet<PerformanceCriterion> PerformanceCriteria { get; set; }
        public virtual DbSet<PerformanceReview> PerformanceReviews { get; set; }
        public virtual DbSet<PerformanceReviewKpi> PerformanceReviewKpis { get; set; }
        public virtual DbSet<PipedriveCourseUpdate> PipedriveCourseUpdates { get; set; }
        public virtual DbSet<PipedriveSync> PipedriveSyncs { get; set; }
        public virtual DbSet<PipedriveUpdate> PipedriveUpdates { get; set; }
        public virtual DbSet<PlanOfAction> PlanOfActions { get; set; }
        public virtual DbSet<PositionDesc> PositionDescs { get; set; }
        public virtual DbSet<Possible> Possibles { get; set; }
        public virtual DbSet<PowerThought> PowerThoughts { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<ProgramApproval> ProgramApprovals { get; set; }
        public virtual DbSet<ProgramLeadWave> ProgramLeadWaves { get; set; }
        public virtual DbSet<QldFundedParticipant> QldFundedParticipants { get; set; }
        public virtual DbSet<QualFundingMatrix> QualFundingMatrices { get; set; }
        public virtual DbSet<QualHour> QualHours { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<QualificationFmiUnitLu> QualificationFmiUnitLus { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<Recognition> Recognitions { get; set; }
        public virtual DbSet<Referrer> Referrers { get; set; }
        public virtual DbSet<RelatedPerson> RelatedPersons { get; set; }
        public virtual DbSet<ReportToOption> ReportToOptions { get; set; }
        public virtual DbSet<ReportingSpreadsheet> ReportingSpreadsheets { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<ReviewFeedback> ReviewFeedbacks { get; set; }
        public virtual DbSet<ReviewQuestion> ReviewQuestions { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<Rpl> Rpls { get; set; }
        public virtual DbSet<SaleType> SaleTypes { get; set; }
        public virtual DbSet<ScheduledHour> ScheduledHours { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<ShowActivityByProgram> ShowActivityByPrograms { get; set; }
        public virtual DbSet<SpCall> SpCalls { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StateFundingSourceCode> StateFundingSourceCodes { get; set; }
        public virtual DbSet<StatusNowType> StatusNowTypes { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionBackup> SubscriptionBackups { get; set; }
        public virtual DbSet<Suitability> Suitabilities { get; set; }
        public virtual DbSet<TeamView> TeamViews { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestActDump> TestActDumps { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<Tool1> Tools1 { get; set; }
        public virtual DbSet<TrainingPlan> TrainingPlans { get; set; }
        public virtual DbSet<TrainingPlanTemp> TrainingPlanTemps { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public virtual DbSet<UsersOrphaned> UsersOrphaneds { get; set; }
        public virtual DbSet<VActivityLesson> VActivityLessons { get; set; }
        public virtual DbSet<VicFundedParticipant> VicFundedParticipants { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<VtCurrLocation> VtCurrLocations { get; set; }
        public virtual DbSet<VwAaagetMultiplePartId> VwAaagetMultiplePartIds { get; set; }
        public virtual DbSet<VwActivitiesByProgram> VwActivitiesByPrograms { get; set; }
        public virtual DbSet<VwActivitiesByProgramNotInActivityMatrix> VwActivitiesByProgramNotInActivityMatrices { get; set; }
        public virtual DbSet<VwActivityIdsByFmiUnit> VwActivityIdsByFmiUnits { get; set; }
        public virtual DbSet<VwActivityIdsCourseCode> VwActivityIdsCourseCodes { get; set; }
        public virtual DbSet<VwActivityMatrixToElement> VwActivityMatricesToElement { get; set; }
        public virtual DbSet<VwAttendedOrHadTutorial> VwAttendedOrHadTutorials { get; set; }
        public virtual DbSet<VwAuditAll> VwAuditAlls { get; set; }
        public virtual DbSet<VwCoachesByProgram> VwCoachesByPrograms { get; set; }
        public virtual DbSet<VwCompetencyCompletedDateByParticipantId> VwCompetencyCompletedDateByParticipantIds { get; set; }
        public virtual DbSet<VwCourseCompWa> VwCourseCompWas { get; set; }
        public virtual DbSet<VwCourseToActivityKeep> VwCourseToActivityKeeps { get; set; }
        public virtual DbSet<VwDateAchieved> VwDateAchieveds { get; set; }
        public virtual DbSet<VwDiscontinuedNoAchievementsParticipantId> VwDiscontinuedNoAchievementsParticipantIds { get; set; }
        public virtual DbSet<VwFacilitatorsActiveBySurnameStateYear> VwFacilitatorsActiveBySurnameStateYears { get; set; }
        public virtual DbSet<VwFfsonlyWip> VwFfsonlyWips { get; set; }
        public virtual DbSet<VwFirstCompetencyAchievedByParticipantId> VwFirstCompetencyAchievedByParticipantIds { get; set; }
        public virtual DbSet<VwFmiUnitToActivitiesByCourseId> VwFmiUnitToActivitiesByCourseIds { get; set; }
        public virtual DbSet<VwFmiUnitToCourse> VwFmiUnitToCourses { get; set; }
        public virtual DbSet<VwFmiUnitsByFirstLessonId> VwFmiUnitsByFirstLessonIds { get; set; }
        public virtual DbSet<VwFmiUnitsByLessonId> VwFmiUnitsByLessonIds { get; set; }
        public virtual DbSet<VwHouseKeepingDuplicatePostcodesForHomeCity> VwHouseKeepingDuplicatePostcodesForHomeCities { get; set; }
        public virtual DbSet<VwHouseKeepingNoPhone> VwHouseKeepingNoPhones { get; set; }
        public virtual DbSet<VwHouseKeepingPriorWithNoDetail> VwHouseKeepingPriorWithNoDetails { get; set; }
        public virtual DbSet<VwHousekeepingMismatchedDob> VwHousekeepingMismatchedDobs { get; set; }
        public virtual DbSet<VwHousekeepingParticipantEnrolmentFormWrongUserId> VwHousekeepingParticipantEnrolmentFormWrongUserIds { get; set; }
        public virtual DbSet<VwLeadActivityDetailOnly> VwLeadActivityDetailOnlies { get; set; }
        public virtual DbSet<VwLeadresult> VwLeadresults { get; set; }
        public virtual DbSet<VwListForAndrew> VwListForAndrews { get; set; }
        public virtual DbSet<VwManagerMentorInEnrolleeVersusRelatedParty> VwManagerMentorInEnrolleeVersusRelatedParties { get; set; }
        public virtual DbSet<VwMinEvidenceDateByParticipantId> VwMinEvidenceDateByParticipantIds { get; set; }
        public virtual DbSet<VwModule1AttendedOrDiscontinuedIsFalse> VwModule1AttendedOrDiscontinuedIsFalses { get; set; }
        public virtual DbSet<VwMostRecentParticipantHavingNonNullAdressByUserId> VwMostRecentParticipantHavingNonNullAdressByUserIds { get; set; }
        public virtual DbSet<VwNswFunded> VwNswFundeds { get; set; }
        public virtual DbSet<VwPParticipantActivity> VwPParticipantActivities { get; set; }
        public virtual DbSet<VwPartCompByFirstStartDate> VwPartCompByFirstStartDates { get; set; }
        public virtual DbSet<VwPartCompByNumActiveAndCompletedUnit> VwPartCompByNumActiveAndCompletedUnits { get; set; }
        public virtual DbSet<VwPartCompByNumActiveUnit> VwPartCompByNumActiveUnits { get; set; }
        public virtual DbSet<VwPartCompDatesAllPlugInPartId> VwPartCompDatesAllPlugInPartIds { get; set; }
        public virtual DbSet<VwPartCompDiscontinuedWithNullEvidenceDate> VwPartCompDiscontinuedWithNullEvidenceDates { get; set; }
        public virtual DbSet<VwPartCompFirstStartDateByPartId> VwPartCompFirstStartDateByPartIds { get; set; }
        public virtual DbSet<VwPartCompFirstStartDateNonNullEvidenceDateOnly> VwPartCompFirstStartDateNonNullEvidenceDateOnlies { get; set; }
        public virtual DbSet<VwPartCompPrimaryQualRow> VwPartCompPrimaryQualRows { get; set; }
        public virtual DbSet<VwPartCompProgramCommencementDate> VwPartCompProgramCommencementDates { get; set; }
        public virtual DbSet<VwPartCompSecondaryQualRow> VwPartCompSecondaryQualRows { get; set; }
        public virtual DbSet<VwPartSchedHour> VwPartSchedHours { get; set; }
        public virtual DbSet<VwPartSchedHoursByUnit> VwPartSchedHoursByUnits { get; set; }
        public virtual DbSet<VwParticipantByFirstActivityDate> VwParticipantByFirstActivityDates { get; set; }
        public virtual DbSet<VwParticipantCompetencyAttendedOrTuteDatePresentLast4Month> VwParticipantCompetencyAttendedOrTuteDatePresentLast4Months { get; set; }
        public virtual DbSet<VwParticipantCompetencyStartDatesFromNowMinus2Year> VwParticipantCompetencyStartDatesFromNowMinus2Years { get; set; }
        public virtual DbSet<VwParticipantCompetencyUnitCountByParticipantQualificationId> VwParticipantCompetencyUnitCountByParticipantQualificationIds { get; set; }
        public virtual DbSet<VwParticipantEndDatesFutureOnly> VwParticipantEndDatesFutureOnlies { get; set; }
        public virtual DbSet<VwParticipantFmiUnitIdFirstWorkshopDate> VwParticipantFmiUnitIdFirstWorkshopDates { get; set; }
        public virtual DbSet<VwParticipantHoursWState> VwParticipantHoursWStates { get; set; }
        public virtual DbSet<VwParticipantReport> VwParticipantReports { get; set; }
        public virtual DbSet<VwParticipantStartDatesFutureOnly> VwParticipantStartDatesFutureOnlies { get; set; }
        public virtual DbSet<VwParticipantStatusChangeLatest> VwParticipantStatusChangeLatests { get; set; }
        public virtual DbSet<VwParticipantStatusChangesWithdrawn> VwParticipantStatusChangesWithdrawns { get; set; }
        public virtual DbSet<VwParticipantswithNonNullFundingReported> VwParticipantswithNonNullFundingReporteds { get; set; }
        public virtual DbSet<VwParticpantsByPcompLocationVsProgLocation> VwParticpantsByPcompLocationVsProgLocations { get; set; }
        public virtual DbSet<VwPrimaryQualToFunding> VwPrimaryQualToFundings { get; set; }
        public virtual DbSet<VwProgramActivityLessonLessonMatrix> VwProgramActivityLessonLessonMatrices { get; set; }
        public virtual DbSet<VwProgramParticipantCountsNonDiscontinued> VwProgramParticipantCountsNonDiscontinueds { get; set; }
        public virtual DbSet<VwProgramToActivitiesLessonsElementsPerfCriteriaMaster> VwProgramToActivitiesLessonsElementsPerfCriteriaMasters { get; set; }
        public virtual DbSet<VwProgramToAllWorkshop> VwProgramToAllWorkshops { get; set; }
        public virtual DbSet<VwProgramsAndNextLeadstartDate> VwProgramsAndNextLeadstartDates { get; set; }
        public virtual DbSet<VwQualFundingMatrix> VwQualFundingMatrices { get; set; }
        public virtual DbSet<VwQualFundingMatrixToParticipant> VwQualFundingMatricesToParticipant { get; set; }
        public virtual DbSet<VwSecondaryQualToFunding> VwSecondaryQualToFundings { get; set; }
        public virtual DbSet<VwSecondaryQualificationsFundingMatrix> VwSecondaryQualificationsFundingMatrices { get; set; }
        public virtual DbSet<VwSmartSkilledWithQfm> VwSmartSkilledWithQfms { get; set; }
        public virtual DbSet<VwTransferredParticipant> VwTransferredParticipants { get; set; }
        public virtual DbSet<VwTutorialssAttended> VwTutorialssAttendeds { get; set; }
        public virtual DbSet<VwVettrakClientsA> VwVettrakClientsAs { get; set; }
        public virtual DbSet<VwVettrakClientsB> VwVettrakClientsBs { get; set; }
        public virtual DbSet<VwVicFunded2> VwVicFunded2s { get; set; }
        public virtual DbSet<VwrptAdmin> VwrptAdmins { get; set; }
        public virtual DbSet<VwrptFacilitatorRating> VwrptFacilitatorRatings { get; set; }
        public virtual DbSet<WorkArea> WorkAreas { get; set; }
        public virtual DbSet<Workbook> Workbooks { get; set; }
        public virtual DbSet<WorkflowEvent> WorkflowEvents { get; set; }
        public virtual DbSet<Workshop> Workshops { get; set; }
        public virtual DbSet<WorkshopApproval> WorkshopApprovals { get; set; }
        public virtual DbSet<Xml> Xmls { get; set; }
        public virtual DbSet<ZtempPSoa2Verified> ZtempPSoa2Verifieds { get; set; }
        public virtual DbSet<ZtempPSoa2Verifiedtotal> ZtempPSoa2Verifiedtotals { get; set; }
        public virtual DbSet<ZtempRpForPdpDia> ZtempRpForPdpDias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.172.26.15;Initial Catalog=FeedbackOnline_UAT;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Accomplishment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("accomplishment");

                entity.HasIndex(e => e.AccomplishmentId, "PK45")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Accomplishment1)
                    .HasColumnType("text")
                    .HasColumnName("accomplishment");

                entity.Property(e => e.AccomplishmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("accomplishment_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccomplishmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("accomplishment_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<ActActivity>(entity =>
            {
                entity.HasKey(e => e.Historyid)
                    .HasName("PK_ACT_ACTIVITIES_1");

                entity.ToTable("ACT_ACTIVITIES");

                entity.Property(e => e.Historyid)
                    .ValueGeneratedNever()
                    .HasColumnName("HISTORYID")
                    .HasComment("Matching with column HISTORYID from table TBL_HISTORY of ACT Database");

                entity.Property(e => e.Activity)
                    .HasMaxLength(64)
                    .HasColumnName("ACTIVITY")
                    .HasComment("Matching with column NAME from table TBL_ACTIVITYTYPE of ACT Database");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE")
                    .HasComment("Matching with column ENDDATE from table TBL_HISTORY of ACT Database");

                entity.Property(e => e.Result)
                    .HasMaxLength(64)
                    .HasColumnName("RESULT")
                    .HasComment("Matching with column NAME from table TBL_HISTORYTYPE of ACT Database");

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(128)
                    .HasColumnName("USERLOGIN")
                    .HasComment("Matching with column USERLOGIN from table TBL_USER of ACT Database");
            });

            modelBuilder.Entity<ActionStep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("action_step");

                entity.HasIndex(e => new { e.GoalId, e.StepOrder }, "PK27")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ActionsStep)
                    .HasMaxLength(2000)
                    .HasColumnName("actions_step");

                entity.Property(e => e.CompletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("completed_date");

                entity.Property(e => e.GoalId).HasColumnName("goal_id");

                entity.Property(e => e.ReviewedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("reviewed_date");

                entity.Property(e => e.StepOrder).HasColumnName("step_order");

                entity.Property(e => e.TargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("target_date");
            });

            modelBuilder.Entity<ActionStepUser>(entity =>
            {
                entity.HasKey(e => new { e.GoalId, e.StepOrder })
                    .HasName("PK27_1")
                    .IsClustered(false);

                entity.ToTable("action_step_user");

                entity.Property(e => e.GoalId).HasColumnName("goal_id");

                entity.Property(e => e.StepOrder).HasColumnName("step_order");

                entity.Property(e => e.ActionsStep)
                    .HasMaxLength(2000)
                    .HasColumnName("actions_step");

                entity.Property(e => e.CompletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("completed_date");

                entity.Property(e => e.ReviewedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("reviewed_date");

                entity.Property(e => e.TargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("target_date");

                entity.HasOne(d => d.Goal)
                    .WithMany(p => p.ActionStepUsers)
                    .HasForeignKey(d => d.GoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refgoal_user94");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("pk_activity")
                    .IsClustered(false);

                entity.ToTable("activity");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("activity_desc");

                entity.Property(e => e.ActivityPlatform)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("activity_platform");

                entity.Property(e => e.ActivityText)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("activity_text");

                entity.Property(e => e.ActivityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("activity_title");

                entity.Property(e => e.ActivityXml)
                    .HasColumnType("xml")
                    .HasColumnName("activity_xml");

                entity.Property(e => e.ActivityXmlBackup)
                    .HasColumnType("xml")
                    .HasColumnName("activity_xml_backup");

                entity.Property(e => e.Alternative).HasColumnName("alternative");

                entity.Property(e => e.AssessmentMethodId).HasColumnName("assessment_method_id");

                entity.Property(e => e.AutoAssess).HasColumnName("auto_assess");

                entity.Property(e => e.HiddenFromParticipant).HasColumnName("hidden_from_participant");

                entity.Property(e => e.MmActivity).HasColumnName("mm_activity");

                entity.Property(e => e.MmAssessed).HasColumnName("mm_assessed");

                entity.Property(e => e.PdfTemplate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pdf_template");

                entity.Property(e => e.Tool).HasColumnName("tool");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.XslTemplate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("xsl_template");
            });

            modelBuilder.Entity<ActivityComment>(entity =>
            {
                entity.HasKey(e => e.ActivityCommentId)
                    .HasName("PK7")
                    .IsClustered(false);

                entity.ToTable("activity_comments");

                entity.HasIndex(e => new { e.ParticipantId, e.ActivityDetailId }, "activity_comments_1")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ActivityCommentId).HasColumnName("activity_comment_id");

                entity.Property(e => e.ActivityDetailId).HasColumnName("activity_detail_id");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.HasOne(d => d.ActivityDetail)
                    .WithMany(p => p.ActivityComments)
                    .HasForeignKey(d => d.ActivityDetailId)
                    .HasConstraintName("Refactivity_detail6");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ActivityComments)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipant7");
            });

            modelBuilder.Entity<ActivityCommentsNz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("activity_comments_NZ");

                entity.Property(e => e.ActivityCommentId).HasColumnName("activity_comment_id");

                entity.Property(e => e.ActivityDetailId).HasColumnName("activity_detail_id");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<ActivityDetail>(entity =>
            {
                entity.HasKey(e => e.ActivityDetailId)
                    .HasName("pk_activity_detail")
                    .IsClustered(false);

                entity.ToTable("activity_detail");

                entity.HasIndex(e => e.ActivityId, "IDX_activity_id");

                entity.HasIndex(e => e.ParticipantId, "IDX_participant_id");

                entity.HasIndex(e => new { e.ParticipantId, e.ActivityId, e.ActivityDate }, "ak_activity_detail")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ActivityDetailId).HasColumnName("activity_detail_id");

                entity.Property(e => e.ActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activity_date");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.Assessed)
                    .HasColumnType("datetime")
                    .HasColumnName("assessed");

                entity.Property(e => e.Completed)
                    .HasColumnType("datetime")
                    .HasColumnName("completed");

                entity.Property(e => e.Paper)
                    .HasColumnName("paper")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ReviewerParticipantId).HasColumnName("reviewer_participant_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubmitToMm)
                    .HasColumnType("datetime")
                    .HasColumnName("submit_to_mm");

                entity.Property(e => e.WorkareaUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workarea_url");

                entity.Property(e => e.XmlActivityData)
                    .HasColumnType("xml")
                    .HasColumnName("xml_activity_data");

                entity.Property(e => e.XmlActivityDataBackup)
                    .HasColumnType("xml")
                    .HasColumnName("xml_activity_data_backup");

                entity.Property(e => e.XmlTemplate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("xml_template");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityDetails)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refactivity1");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ActivityDetails)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipant5");
            });

            modelBuilder.Entity<ActivityDetailNz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("activity_detail_NZ");

                entity.Property(e => e.ActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activity_date");

                entity.Property(e => e.ActivityDetailId).HasColumnName("activity_detail_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.Assessed)
                    .HasColumnType("datetime")
                    .HasColumnName("assessed");

                entity.Property(e => e.Completed)
                    .HasColumnType("datetime")
                    .HasColumnName("completed");

                entity.Property(e => e.Paper).HasColumnName("paper");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ReviewerParticipantId).HasColumnName("reviewer_participant_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubmitToMm)
                    .HasColumnType("datetime")
                    .HasColumnName("submit_to_mm");

                entity.Property(e => e.WorkareaUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workarea_url");

                entity.Property(e => e.XmlActivityData)
                    .HasColumnType("xml")
                    .HasColumnName("xml_activity_data");

                entity.Property(e => e.XmlActivityDataBackup)
                    .HasColumnType("xml")
                    .HasColumnName("xml_activity_data_backup");

                entity.Property(e => e.XmlTemplate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("xml_template");
            });

            modelBuilder.Entity<ActivityDetailSnapshot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("activity_detail_snapshot");

                entity.Property(e => e.ActivityDetailId).HasColumnName("activity_detail_id");

                entity.Property(e => e.AdsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ads_id");

                entity.Property(e => e.SnapshotDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("snapshot_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.XmlActivityData)
                    .HasColumnType("xml")
                    .HasColumnName("xml_activity_data");
            });

            modelBuilder.Entity<ActivityDetailXtra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("activity_detail_xtra");

                entity.Property(e => e.ActivityDetailId).HasColumnName("activity_detail_id");

                entity.Property(e => e.CompletedOk).HasColumnName("completed_ok");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("first_completed");
            });

            modelBuilder.Entity<ActivityIdChangeHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("activity_id_change_history");

                entity.Property(e => e.ActivityIdHistoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("activity_id_history_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewActivityId).HasColumnName("new_activity_id");

                entity.Property(e => e.NewAlVersion).HasColumnName("new_al_version");

                entity.Property(e => e.NewCourseId).HasColumnName("new_course_id");

                entity.Property(e => e.NewFbolGuiVersionId)
                    .HasColumnName("new_FBOL_GUI_version_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PreviousActivityId).HasColumnName("previous_activity_id");

                entity.Property(e => e.PreviousAlVersion).HasColumnName("previous_al_version");

                entity.Property(e => e.PreviousCourseId).HasColumnName("previous_course_id");

                entity.Property(e => e.PreviousFbolGuiVersionId).HasColumnName("previous_FBOL_GUI_version_id");
            });

            modelBuilder.Entity<ActivityLesson>(entity =>
            {
                entity.HasKey(e => new { e.LessonId, e.ActivityId, e.AlVersion })
                    .HasName("pk_activity_lesson")
                    .IsClustered(false);

                entity.ToTable("activity_lesson");

                entity.HasIndex(e => e.Discussion, "Refactlessondiscussion")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Live, "Refactlessonlive")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discussion).HasColumnName("discussion");

                entity.Property(e => e.DiscussionPlus).HasColumnName("discussion_plus");

                entity.Property(e => e.DuePlus).HasColumnName("due_plus");

                entity.Property(e => e.HideBefore)
                    .HasColumnType("datetime")
                    .HasColumnName("hide_before");

                entity.Property(e => e.LessonDue).HasColumnName("lesson_due");

                entity.Property(e => e.Live).HasColumnName("live");

                entity.Property(e => e.LivePlus).HasColumnName("live_plus");

                entity.Property(e => e.ManualRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manual_ref");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityLessons)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refactivity4");

                entity.HasOne(d => d.DiscussionNavigation)
                    .WithMany(p => p.ActivityLessonDiscussionNavigations)
                    .HasForeignKey(d => d.Discussion)
                    .HasConstraintName("Reflesson10");

                entity.HasOne(d => d.LessonDueNavigation)
                    .WithMany(p => p.ActivityLessonLessonDueNavigations)
                    .HasForeignKey(d => d.LessonDue)
                    .HasConstraintName("Reflesson8");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.ActivityLessonLessons)
                    .HasForeignKey(d => d.LessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reflesson3");

                entity.HasOne(d => d.LiveNavigation)
                    .WithMany(p => p.ActivityLessonLiveNavigations)
                    .HasForeignKey(d => d.Live)
                    .HasConstraintName("Reflesson9");
            });

            modelBuilder.Entity<ActivityMatrix>(entity =>
            {
                entity.HasKey(e => new { e.PerformanceCriteriaId, e.ActivityId, e.CourseId, e.MappingId })
                    .HasName("PKactivity_matrix")
                    .IsClustered(false);

                entity.ToTable("activity_matrix");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.MappingId)
                    .HasColumnName("mapping_id")
                    .HasDefaultValueSql("((2))");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityMatrices)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refactivity789");

                entity.HasOne(d => d.PerformanceCriteria)
                    .WithMany(p => p.ActivityMatrices)
                    .HasForeignKey(d => d.PerformanceCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refperformance_criteria78");
            });

            modelBuilder.Entity<ActivityNewVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("activity__new__version");

                entity.Property(e => e.ActivityDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("activity_desc");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityPlatform)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("activity_platform");

                entity.Property(e => e.ActivityText)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("activity_text");

                entity.Property(e => e.ActivityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("activity_title");

                entity.Property(e => e.ActivityXml)
                    .HasColumnType("xml")
                    .HasColumnName("activity_xml");

                entity.Property(e => e.ActivityXmlBackup)
                    .HasColumnType("xml")
                    .HasColumnName("activity_xml_backup");

                entity.Property(e => e.Alternative).HasColumnName("alternative");

                entity.Property(e => e.AssessmentMethodId).HasColumnName("assessment_method_id");

                entity.Property(e => e.AutoAssess).HasColumnName("auto_assess");

                entity.Property(e => e.MmActivity).HasColumnName("mm_activity");

                entity.Property(e => e.MmAssessed).HasColumnName("mm_assessed");

                entity.Property(e => e.NewActivityId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("new_activity_id");

                entity.Property(e => e.PdfTemplate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pdf_template");

                entity.Property(e => e.Tool).HasColumnName("tool");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.WorkshopDateStart)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date_start")
                    .HasComment("Version applies to activities in workshops from this date onwards inclusive.");

                entity.Property(e => e.XslTemplate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("xsl_template");
            });

            modelBuilder.Entity<ActivityReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("activity_receipt");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityReceiptId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("activity_receipt_id");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("date_received");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ReceivedByUserId).HasColumnName("received_by_user_id");
            });

            modelBuilder.Entity<AllType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("all_types");

                entity.Property(e => e.TypeDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("type_description");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("type_id");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type_name");
            });

            modelBuilder.Entity<AllTypeValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("all_type_values");

                entity.Property(e => e.DbValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("db_value");

                entity.Property(e => e.DbValueSchemaTypeId).HasColumnName("db_value_schema_type_id");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("display_value");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.TypeValueId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("type_value_id");
            });

            modelBuilder.Entity<AnzscoCode>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("anzsco_codes");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Major)
                    .HasMaxLength(2000)
                    .HasColumnName("major");

                entity.Property(e => e.MajorClientId).HasColumnName("major_client_id");

                entity.Property(e => e.Minor)
                    .HasMaxLength(2000)
                    .HasColumnName("minor");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(4000)
                    .HasColumnName("occupation");

                entity.Property(e => e.Submajor)
                    .HasMaxLength(2000)
                    .HasColumnName("submajor");

                entity.Property(e => e.Unit)
                    .HasMaxLength(2000)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<AnzscoCodesAdditional>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("anzsco_codes_additional");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Major)
                    .HasMaxLength(200)
                    .HasColumnName("major")
                    .IsFixedLength(true);

                entity.Property(e => e.Minor)
                    .HasMaxLength(200)
                    .HasColumnName("minor")
                    .IsFixedLength(true);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(200)
                    .HasColumnName("occupation")
                    .IsFixedLength(true);

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Submajor)
                    .HasMaxLength(200)
                    .HasColumnName("submajor")
                    .IsFixedLength(true);

                entity.Property(e => e.Unit)
                    .HasMaxLength(200)
                    .HasColumnName("unit")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AssessmentEvidence>(entity =>
            {
                entity.HasKey(e => new { e.AssessmentId, e.WorkshopId, e.ParticipantId });

                entity.ToTable("assessment_evidence");

                entity.HasIndex(e => new { e.AssessmentId, e.WorkshopId, e.ParticipantId }, "PK18")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AssessmentId).HasColumnName("assessment_id");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Completed).HasColumnName("completed");
            });

            modelBuilder.Entity<AssessmentMatrix>(entity =>
            {
                entity.HasKey(e => new { e.PerformanceCriteriaId, e.LessonQuestionId })
                    .HasName("PK91")
                    .IsClustered(false);

                entity.ToTable("assessment_matrix");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");

                entity.Property(e => e.LessonQuestionId).HasColumnName("lesson_question_id");

                entity.HasOne(d => d.LessonQuestion)
                    .WithMany(p => p.AssessmentMatrices)
                    .HasForeignKey(d => d.LessonQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reflesson_questions127");

                entity.HasOne(d => d.PerformanceCriteria)
                    .WithMany(p => p.AssessmentMatrices)
                    .HasForeignKey(d => d.PerformanceCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refperformance_criteria126");
            });

            modelBuilder.Entity<AssessmentMethod>(entity =>
            {
                entity.ToTable("assessment_method");

                entity.Property(e => e.AssessmentMethodId).HasColumnName("assessment_method_id");

                entity.Property(e => e.AssessmentDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("assessment_desc");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AssessmentTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("assessment_task");

                entity.HasIndex(e => e.AssessmentId, "PK14")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AssessmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("assessment_id");

                entity.Property(e => e.AssessmentTitle)
                    .HasMaxLength(200)
                    .HasColumnName("assessment_title");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("attendance");

                entity.HasIndex(e => e.Attended, "IDX_attended");

                entity.HasIndex(e => e.ParticipantId, "IDX_participant_id");

                entity.HasIndex(e => new { e.WorkshopId, e.ParticipantId }, "PK11")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AttendanceWorkshopId).HasColumnName("attendance_workshop_id");

                entity.Property(e => e.Attended).HasColumnName("attended");

                entity.Property(e => e.CertGiven).HasColumnName("cert_given");

                entity.Property(e => e.CoachAttended).HasColumnName("Coach_attended");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MmAttended).HasColumnName("MM_attended");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(20)
                    .HasColumnName("reason_code");

                entity.Property(e => e.TutorialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tutorial_date");

                entity.Property(e => e.TutorialWith).HasColumnName("tutorial_with");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<AttendanceReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("attendance_reason");

                entity.HasIndex(e => e.ReasonCode, "PK36")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("reason_code");

                entity.Property(e => e.ReasonTitle)
                    .HasMaxLength(40)
                    .HasColumnName("reason_title");
            });

            modelBuilder.Entity<Auspost>(entity =>
            {
                entity.ToTable("auspost");

                entity.Property(e => e.AuspostId).HasColumnName("auspost_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("postcode")
                    .IsFixedLength(true);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.StateNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("state_number")
                    .IsFixedLength(true);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(500)
                    .HasColumnName("suburb");
            });

            modelBuilder.Entity<AvetmissNat00060>(entity =>
            {
                entity.ToTable("avetmiss_nat00060");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.ModuleUnitOfCompetencyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("module_unit_of_competency_flag")
                    .IsFixedLength(true);

                entity.Property(e => e.ModuleUnitOfCompetencyFoeIdentifier)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("module_unit_of_competency_foe_identifier");

                entity.Property(e => e.ModuleUnitOfCompetencyIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("module_unit_of_competency_identifier");

                entity.Property(e => e.ModuleUnitOfCompetencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("module_unit_of_competency_name");

                entity.Property(e => e.NominalHours).HasColumnName("nominal_hours");

                entity.Property(e => e.NominalHoursAct).HasColumnName("nominal_hours_act");

                entity.Property(e => e.NominalHoursNsw).HasColumnName("nominal_hours_nsw");

                entity.Property(e => e.NominalHoursNt).HasColumnName("nominal_hours_nt");

                entity.Property(e => e.NominalHoursQld).HasColumnName("nominal_hours_qld");

                entity.Property(e => e.NominalHoursSa).HasColumnName("nominal_hours_sa");

                entity.Property(e => e.NominalHoursTas).HasColumnName("nominal_hours_tas");

                entity.Property(e => e.NominalHoursWa).HasColumnName("nominal_hours_wa");

                entity.Property(e => e.VetFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("vet_flag")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AvetmissNat00060Temp>(entity =>
            {
                entity.ToTable("avetmiss_nat00060_temp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.ModuleUnitOfCompetencyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("module_unit_of_competency_flag")
                    .IsFixedLength(true);

                entity.Property(e => e.ModuleUnitOfCompetencyFoeIdentifier)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("module_unit_of_competency_foe_identifier");

                entity.Property(e => e.ModuleUnitOfCompetencyIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("module_unit_of_competency_identifier");

                entity.Property(e => e.ModuleUnitOfCompetencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("module_unit_of_competency_name");

                entity.Property(e => e.NominalHours).HasColumnName("nominal_hours");

                entity.Property(e => e.NominalHoursNsw).HasColumnName("nominal_hours_nsw");

                entity.Property(e => e.NominalHoursQld).HasColumnName("nominal_hours_qld");

                entity.Property(e => e.NominalHoursSa).HasColumnName("nominal_hours_sa");

                entity.Property(e => e.NominalHoursTas).HasColumnName("nominal_hours_tas");

                entity.Property(e => e.NominalHoursWa).HasColumnName("nominal_hours_wa");

                entity.Property(e => e.VetFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("vet_flag")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BoralParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Boral_Participants");

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourseGraduation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Course Graduation");

                entity.Property(e => e.CourseType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Course Type");

                entity.Property(e => e.DateOfWdDeffTransferred)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Date of WD/Deff/Transferred");

                entity.Property(e => e.Fef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FEF");

                entity.Property(e => e.LastActiveModule)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Last Active Module");

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerMentor)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Manager/Mentor");

                entity.Property(e => e.Participant)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QualificationIssued)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Qualification Issued");

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Start Date");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingPlanCompleted)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRAINING PLAN COMPLETED");

                entity.Property(e => e.WdDeffNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("WD/Deff notes");
            });

            modelBuilder.Entity<Branding>(entity =>
            {
                entity.ToTable("branding");

                entity.Property(e => e.BrandingId).HasColumnName("branding_id");

                entity.Property(e => e.Banner)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("banner");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Logo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("logo");
            });

            modelBuilder.Entity<Bulletin>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.BulletinDate })
                    .HasName("PK39")
                    .IsClustered(false);

                entity.ToTable("bulletin");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.BulletinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bulletin_date");

                entity.Property(e => e.Notice)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("notice");
            });

            modelBuilder.Entity<CertificateIssued>(entity =>
            {
                entity.HasKey(e => e.CertificateNo);

                entity.ToTable("certificate_issued");

                entity.Property(e => e.CertificateNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("certificate_no");

                entity.Property(e => e.CertType)
                    .HasMaxLength(50)
                    .HasColumnName("cert_type");

                entity.Property(e => e.CertificateIssuedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_issued_date");

                entity.Property(e => e.Competencies)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("competencies");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.Text1).HasColumnName("text_1");

                entity.Property(e => e.Text2).HasColumnName("text_2");

                entity.Property(e => e.Text3).HasColumnName("text_3");

                entity.Property(e => e.Text4).HasColumnName("text_4");
            });

            modelBuilder.Entity<CertificateRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("certificate_register");

                entity.Property(e => e.CertificateId).HasColumnName("certificate_id");

                entity.Property(e => e.CertificateIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_issued");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .HasColumnName("location_name");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");
            });

            modelBuilder.Entity<CertificateText>(entity =>
            {
                entity.HasKey(e => e.TextId);

                entity.ToTable("certificate_text");

                entity.Property(e => e.TextId).HasColumnName("text_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RelatedTextId).HasColumnName("related_text_id");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("state_code");

                entity.Property(e => e.Text)
                    .HasMaxLength(2000)
                    .HasColumnName("text");
            });

            modelBuilder.Entity<Coach>(entity =>
            {
                entity.ToTable("coaches");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("state_code");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CoachRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("coach_record");

                entity.Property(e => e.ActionBlock1Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AskedParticipantAboutFeedbackGivenCall4).HasColumnName("AskedParticipantAboutFeedbackGiven_Call4");

                entity.Property(e => e.BiggestAchievementSinceBlock1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoachCallNumber1FirstTriedDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber1SucceededDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber2FirstTriedDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber2SucceededDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber3FirstTriedDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber3SucceededDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber4FirstTriedDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber4SucceededDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber5FirstTriedDate).HasColumnType("datetime");

                entity.Property(e => e.CoachCallNumber5SucceededDate).HasColumnType("datetime");

                entity.Property(e => e.CoachRecordId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("coach_record_id");

                entity.Property(e => e.CoachUserId).HasColumnName("coach_user_id");

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.Comments2).HasMaxLength(200);

                entity.Property(e => e.ComplaintsRecordObtainedCall4).HasColumnName("ComplaintsRecordObtained_Call4");

                entity.Property(e => e.DelegationStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiscussedActionsGoalsCall5).HasColumnName("DiscussedActionsGoals_Call5");

                entity.Property(e => e.EvidencePortfolioStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstTppandTpipactivitiesStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FirstTPPandTPIPActivitiesStatus");

                entity.Property(e => e.FirstTppandTpipactivitiesStatus2).HasColumnName("FirstTPPandTPIPActivitiesStatus_2");

                entity.Property(e => e.FirstTppandTpipactivitiesStatusCall4).HasColumnName("FirstTPPandTPIPActivitiesStatus_Call4");

                entity.Property(e => e.IdeasToolsSuccessfullyAppliedSinceBlock1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InitialDateEmailed).HasColumnType("datetime");

                entity.Property(e => e.ParticipantActionedHpas).HasColumnName("ParticipantActionedHPAs");

                entity.Property(e => e.ParticipantCommencedTppandTpipactivities).HasColumnName("ParticipantCommencedTPPandTPIPActivities");

                entity.Property(e => e.ParticipantDiscussedEvidenceFolioWithMm).HasColumnName("ParticipantDiscussedEvidenceFolioWithMM");

                entity.Property(e => e.ParticipantDiscussedHpasWithMm).HasColumnName("ParticipantDiscussedHPAsWithMM");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ParticipantMetWithMm).HasColumnName("ParticipantMetWithMM");

                entity.Property(e => e.ProgramGoalStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.ProgressOnActionsMoreTimeOnHpas).HasColumnName("ProgressOnActionsMoreTimeOnHPAs");

                entity.Property(e => e.SecondTppandTpipactivitiesStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SecondTPPandTPIPActivitiesStatus");

                entity.Property(e => e.SubmittedYellowBookletBlock1).HasColumnType("datetime");

                entity.Property(e => e.SubmittedYellowBookletBlock2).HasColumnType("datetime");

                entity.Property(e => e.SubmittedYellowBookletBlock3).HasColumnType("datetime");

                entity.Property(e => e.TandDplanUnderway).HasColumnName("TandDPlanUnderway");

                entity.Property(e => e.TandDplanUnderwayCall4).HasColumnName("TandDPlanUnderway_Call4");

                entity.Property(e => e.ThirdPartyReportSoughtFromMm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ThirdPartyReportSoughtFromMM");
            });

            modelBuilder.Entity<CoachingRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("coaching_records");

                entity.Property(e => e.ActionsAssessmentsDiscussed)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoachRecordId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("coach_record_id");

                entity.Property(e => e.CommentsWinsSuccesses)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateAttempted).HasColumnType("smalldatetime");

                entity.Property(e => e.DateContacted).HasColumnType("smalldatetime");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("comment");

                entity.HasIndex(e => new { e.WorkshopId, e.ParticipantId, e.UserId }, "PK37")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Comment1)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasColumnName("comment");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("company");

                entity.Property(e => e.AccountManager).HasColumnName("account_manager");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Company1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.CompanyHistoryId).HasColumnName("company_history_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CompanySize).HasColumnName("company_size");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EnrolledCount).HasColumnName("enrolled_count");

                entity.Property(e => e.EnrolledCount12months).HasColumnName("enrolled_count_12months");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.FbolLogonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fbol_logon_id");

                entity.Property(e => e.Industry)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("industry");

                entity.Property(e => e.License)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("license");

                entity.Property(e => e.LicenseId).HasColumnName("license_id");

                entity.Property(e => e.MinimumExpiration)
                    .HasColumnType("datetime")
                    .HasColumnName("minimum_expiration");

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.PresentationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("presentation_date");

                entity.Property(e => e.Presenter).HasColumnName("presenter");

                entity.Property(e => e.Quota).HasColumnName("quota");

                entity.Property(e => e.RegisteredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registered_date");

                entity.Property(e => e.RegistrationTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("registration_type_code");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status_code");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<CompanyAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("company_all");

                entity.Property(e => e.AccountManager).HasColumnName("account_manager");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.CompanyHistoryId).HasColumnName("company_history_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CompanySize).HasColumnName("company_size");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EnrolledCount).HasColumnName("enrolled_count");

                entity.Property(e => e.EnrolledCount12months).HasColumnName("enrolled_count_12months");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.Industry)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("industry");

                entity.Property(e => e.License)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("license");

                entity.Property(e => e.LicenseId).HasColumnName("license_id");

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.PresentationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("presentation_date");

                entity.Property(e => e.Presenter).HasColumnName("presenter");

                entity.Property(e => e.Quota).HasColumnName("quota");

                entity.Property(e => e.RegisteredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registered_date");

                entity.Property(e => e.RegistrationTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("registration_type_code");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status_code");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<CompanyCatscanv2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("company_catscanv2");

                entity.Property(e => e.AccountManager)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("account_manager");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.CompanyHistoryId).HasColumnName("company_history_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CompanySize).HasColumnName("company_size");

                entity.Property(e => e.EnrolledCount).HasColumnName("enrolled_count");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.Industry)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("industry");

                entity.Property(e => e.Licensee)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("licensee");

                entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.Presenter)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("presenter");

                entity.Property(e => e.RegisteredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registered_date");

                entity.Property(e => e.RegistrationTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("registration_type_code");

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status_code");
            });

            modelBuilder.Entity<CompetencyAchieved>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.FmiUnitId, e.QualificationId });

                entity.ToTable("competency_achieved");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.Agreed).HasColumnName("agreed");

                entity.Property(e => e.AssessorId).HasColumnName("assessor_id");

                entity.Property(e => e.CompetencyAchievedId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("competency_achieved_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("date_achieved");
            });

            modelBuilder.Entity<CompetencyLog>(entity =>
            {
                entity.HasKey(e => e.CompetencyLogId)
                    .HasName("PK64")
                    .IsClustered(false);

                entity.ToTable("competency_log");

                entity.Property(e => e.CompetencyLogId).HasColumnName("competency_log_id");

                entity.Property(e => e.OtherEvidence)
                    .HasMaxLength(1000)
                    .HasColumnName("other_evidence");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("section");
            });

            modelBuilder.Entity<CompetencyMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("competency_matrix");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.ElementRange)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("element_range");

                entity.Property(e => e.ElementRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("element_ref");

                entity.Property(e => e.ElementTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("element_title");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitDesc)
                    .HasMaxLength(1000)
                    .HasColumnName("fmi_unit_desc");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FmiUnitTitle)
                    .HasMaxLength(100)
                    .HasColumnName("fmi_unit_title");

                entity.Property(e => e.PerformanceCriteriaDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_desc");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");

                entity.Property(e => e.PerformanceCriteriaRange)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_range");

                entity.Property(e => e.PerformanceCriteriaRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_ref");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("course");

                entity.HasIndex(e => e.CourseCode, "IDX_course_code");

                entity.HasIndex(e => e.EventTypeId, "IDX_event_type_id");

                entity.HasIndex(e => e.CourseId, "pk4")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.AntaCourseCode)
                    .HasMaxLength(100)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BrandingId).HasColumnName("branding_id");

                entity.Property(e => e.CaapPrice).HasColumnName("caap_price");

                entity.Property(e => e.CertType)
                    .HasMaxLength(50)
                    .HasComment("1: SOA version 1\r\n2: Certificate version 1\r\n3: SOA version 2\r\n4: Certificate version 2\r\n5: ");

                entity.Property(e => e.CourseBrochure)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("course_brochure");

                entity.Property(e => e.CourseBrochureDual)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("course_brochure_dual");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseDuration)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("course_duration");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(100)
                    .HasColumnName("course_name");

                entity.Property(e => e.CreditUnits).HasColumnName("credit_units");

                entity.Property(e => e.CurrentAlVersion).HasColumnName("current_al_version");

                entity.Property(e => e.CurrentMappingId).HasColumnName("current_mapping_id");

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.DualQualifications).HasColumnName("dual_qualifications");

                entity.Property(e => e.EventTypeId).HasColumnName("event_type_id");

                entity.Property(e => e.ExpiredQual).HasColumnName("expired_qual");

                entity.Property(e => e.FacFee1).HasColumnName("fac_fee_1");

                entity.Property(e => e.FacFee2).HasColumnName("fac_fee_2");

                entity.Property(e => e.FacFee3).HasColumnName("fac_fee_3");

                entity.Property(e => e.Fbol)
                    .HasColumnName("fbol")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPartial).HasColumnName("is_partial");

                entity.Property(e => e.LeadFromAlVersion).HasColumnName("lead_from_al_version");

                entity.Property(e => e.McrDisabled)
                    .HasColumnName("mcr_disabled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoCoach).HasColumnName("no_coach");

                entity.Property(e => e.NswCommitmentId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NSW_commitment_id");

                entity.Property(e => e.OnlineCourse)
                    .HasColumnName("online_course")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PartFirstPay).HasColumnName("part_first_pay");

                entity.Property(e => e.PartSecondPay).HasColumnName("part_second_pay");

                entity.Property(e => e.PcrDisabled)
                    .HasColumnName("pcr_disabled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdpLessonId).HasColumnName("pdp_lesson_id");

                entity.Property(e => e.PgDisabled).HasColumnName("pg_disabled");

                entity.Property(e => e.Platform).HasColumnName("platform");

                entity.Property(e => e.Push)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("PUSH");

                entity.Property(e => e.PushDualQual)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("PUSH_DualQual");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.QualificationLevel).HasColumnName("qualification_level");

                entity.Property(e => e.ReplacedBy).HasColumnName("replaced_by");

                entity.Property(e => e.Request)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("request");

                entity.Property(e => e.ResourceFee).HasColumnName("resource_fee");

                entity.Property(e => e.RrpPrice).HasColumnName("rrp_price");

                entity.Property(e => e.SecondaryQualificationId).HasColumnName("secondary_qualification_id");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.TableBooking)
                    .HasColumnName("table_booking")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TpPdfHoursText)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TP_Pdf_HoursText");

                entity.Property(e => e.TuitionFee)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("tuition_fee");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("version");

                entity.Property(e => e.VtgTuitionFeeHour)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vtg_tuition_fee_hour");

                entity.Property(e => e.VtgTuitionFeeHourDual)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vtg_tuition_fee_hour_dual");

                entity.Property(e => e.WwDisabled)
                    .HasColumnName("ww_disabled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XLlnId).HasColumnName("xLLN_id");
            });

            modelBuilder.Entity<CourseCompetency>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.FmiUnitId, e.MappingId, e.QualificationId })
                    .HasName("PKcoursecomp")
                    .IsClustered(false);

                entity.ToTable("course_competency");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.CoursePart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_part");

                entity.Property(e => e.FmiUnitRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fmi_unit_ref");

                entity.Property(e => e.ForRpl).HasColumnName("for_rpl");

                entity.Property(e => e.WhenAdded)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("when_added")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.FmiUnit)
                    .WithMany(p => p.CourseCompetencies)
                    .HasForeignKey(d => d.FmiUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reffmi_unit98");
            });

            modelBuilder.Entity<CourseEvaluation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("course_evaluation");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsPostOv).HasColumnName("is_post_OV");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Q20a).HasColumnType("text");

                entity.Property(e => e.Q20b).HasColumnType("text");

                entity.Property(e => e.Q42).HasColumnType("text");

                entity.Property(e => e.Q43).HasColumnType("text");
            });

            modelBuilder.Entity<CourseFeePeriod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("course_fee_period");

                entity.Property(e => e.ActiveDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("active_date");

                entity.Property(e => e.CourseFeePeriodId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("course_fee_period_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.GovtContribution)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("govt_contribution");

                entity.Property(e => e.Push)
                    .HasColumnType("decimal(4, 1)")
                    .HasColumnName("PUSH");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.ResourceFee)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("resource__fee");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("state_code");

                entity.Property(e => e.TuitionFee)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("tuition__fee");
            });

            modelBuilder.Entity<CourseHistory>(entity =>
            {
                entity.HasKey(e => e.CourseHistoryId)
                    .HasName("PK63")
                    .IsClustered(false);

                entity.ToTable("course_history");

                entity.Property(e => e.CourseHistoryId).HasColumnName("course_history_id");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .HasColumnName("action");

                entity.Property(e => e.ActionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("action_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .HasColumnName("location");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<CourseLln>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("course_LLN");

                entity.Property(e => e.ActiveFrom)
                    .HasColumnType("date")
                    .HasColumnName("active_from");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CourseLlnId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("course_LLN_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LlnId).HasColumnName("LLN_id");
            });

            modelBuilder.Entity<CourseMapping>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.MappingId })
                    .HasName("PK_mapping_locked");

                entity.ToTable("course_mapping");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.MappingLockedId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("mapping_locked_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");
            });

            modelBuilder.Entity<CoursePart>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("course_parts");

                entity.Property(e => e.PartId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_id");

                entity.Property(e => e.PartTitle)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_title");
            });

            modelBuilder.Entity<CoursePowerThought>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("course_power_thoughts");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.PtCourseId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pt_course_id");

                entity.Property(e => e.PtId).HasColumnName("pt_id");
            });

            modelBuilder.Entity<CourseQualification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Course_Qualification");

                entity.Property(e => e.AntaCourseCode)
                    .HasMaxLength(100)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.AnzscoIdentifier)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ANZSCO_identifier");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.BrandingId).HasColumnName("branding_id");

                entity.Property(e => e.CaapPrice).HasColumnName("caap_price");

                entity.Property(e => e.CertType).HasMaxLength(50);

                entity.Property(e => e.CourseBrochure)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("course_brochure");

                entity.Property(e => e.CourseBrochureDual)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("course_brochure_dual");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseDuration)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("course_duration");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(100)
                    .HasColumnName("course_name");

                entity.Property(e => e.CpsNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cps_number");

                entity.Property(e => e.CreditUnits).HasColumnName("credit_units");

                entity.Property(e => e.CurrentAlVersion).HasColumnName("current_al_version");

                entity.Property(e => e.CurrentMappingId).HasColumnName("current_mapping_id");

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.DualQualifications).HasColumnName("dual_qualifications");

                entity.Property(e => e.EventTypeId).HasColumnName("event_type_id");

                entity.Property(e => e.Expr2).HasMaxLength(100);

                entity.Property(e => e.FacFee1).HasColumnName("fac_fee_1");

                entity.Property(e => e.FacFee2).HasColumnName("fac_fee_2");

                entity.Property(e => e.FacFee3).HasColumnName("fac_fee_3");

                entity.Property(e => e.Fbol).HasColumnName("fbol");

                entity.Property(e => e.FoeIdentifier)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FOE_identifier");

                entity.Property(e => e.GovtContribution)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("govt_contribution");

                entity.Property(e => e.LeadFromAlVersion).HasColumnName("lead_from_al_version");

                entity.Property(e => e.LoeIdentifier)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOE_identifier");

                entity.Property(e => e.McrDisabled).HasColumnName("mcr_disabled");

                entity.Property(e => e.NextQualLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("next_qual_level");

                entity.Property(e => e.NoCoach).HasColumnName("no_coach");

                entity.Property(e => e.NominalHoursAct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_act");

                entity.Property(e => e.NominalHoursNsw)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_nsw");

                entity.Property(e => e.NominalHoursNt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_nt");

                entity.Property(e => e.NominalHoursQld)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_qld");

                entity.Property(e => e.NominalHoursSa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_sa");

                entity.Property(e => e.NominalHoursTas)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_tas");

                entity.Property(e => e.NominalHoursVic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_vic");

                entity.Property(e => e.NominalHoursWa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_wa");

                entity.Property(e => e.NswCommitmentId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NSW_commitment_id");

                entity.Property(e => e.OnlineCourse).HasColumnName("online_course");

                entity.Property(e => e.PartFirstPay).HasColumnName("part_first_pay");

                entity.Property(e => e.PartSecondPay).HasColumnName("part_second_pay");

                entity.Property(e => e.PcrDisabled).HasColumnName("pcr_disabled");

                entity.Property(e => e.PdpLessonId).HasColumnName("pdp_lesson_id");

                entity.Property(e => e.PgDisabled).HasColumnName("pg_disabled");

                entity.Property(e => e.Platform).HasColumnName("platform");

                entity.Property(e => e.Push)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("PUSH");

                entity.Property(e => e.PushDualQual)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("PUSH_DualQual");

                entity.Property(e => e.QualCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qual_code");

                entity.Property(e => e.QualLevel).HasColumnName("qual_level");

                entity.Property(e => e.QualLevelTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qual_level_title");

                entity.Property(e => e.QualStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qual_status");

                entity.Property(e => e.QualTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("qual_title");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.QualificationLevel).HasColumnName("qualification_level");

                entity.Property(e => e.ReplacedBy).HasColumnName("replaced_by");

                entity.Property(e => e.Request)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("request");

                entity.Property(e => e.ResourceFee).HasColumnName("resource_fee");

                entity.Property(e => e.RrpPrice).HasColumnName("rrp_price");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.TableBooking).HasColumnName("table_booking");

                entity.Property(e => e.TuitionFee)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("tuition_fee");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("version");

                entity.Property(e => e.VtgTuitionFeeHour)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vtg_tuition_fee_hour");

                entity.Property(e => e.VtgTuitionFeeHourDual)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vtg_tuition_fee_hour_dual");

                entity.Property(e => e.WwDisabled).HasColumnName("ww_disabled");
            });

            modelBuilder.Entity<CpActionStep>(entity =>
            {
                entity.HasKey(e => new { e.StepId, e.ParticipantId });

                entity.ToTable("CP_action_steps");

                entity.Property(e => e.StepId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("stepID");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ActionStep)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompleteDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stakeholders)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TargetDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CpBudget>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ParticipantId });

                entity.ToTable("CP_budget");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("itemID");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Item)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DailyWin>(entity =>
            {
                entity.HasKey(e => e.DailyWinsId)
                    .HasName("pk_daily_wins")
                    .IsClustered(false);

                entity.ToTable("daily_wins");

                entity.Property(e => e.DailyWinsId).HasColumnName("daily_wins_id");

                entity.Property(e => e.Business1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("business1");

                entity.Property(e => e.Business2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("business2");

                entity.Property(e => e.Business3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("business3");

                entity.Property(e => e.Business4)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("business4");

                entity.Property(e => e.Business5)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("business5");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Personal1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("personal1");

                entity.Property(e => e.Personal2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("personal2");

                entity.Property(e => e.Personal3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("personal3");

                entity.Property(e => e.Personal4)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("personal4");

                entity.Property(e => e.Personal5)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("personal5");

                entity.Property(e => e.WinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("win_date");

                entity.Property(e => e.WinsToday)
                    .HasColumnType("text")
                    .HasColumnName("wins_today");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.DailyWins)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipant21");
            });

            modelBuilder.Entity<DoNotSendA>(entity =>
            {
                entity.HasKey(e => e.DomainName);

                entity.ToTable("do_not_send_as");

                entity.Property(e => e.DomainName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("domain_name");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("create_date");
            });

            modelBuilder.Entity<DocumentList>(entity =>
            {
                entity.ToTable("document_list");

                entity.Property(e => e.DocumentListId).HasColumnName("document_list_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.ListName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("list_name");

                entity.Property(e => e.OrderBy).HasColumnName("order_by");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasColumnName("title");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<DownerActivityBook>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.BookNumber, e.ActivityId });

                entity.ToTable("downer_activity_book");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.BookNumber).HasColumnName("book_number");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            });

            modelBuilder.Entity<EbookCourseMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ebook_course_materials");

                entity.Property(e => e.AllowPrinting).HasColumnName("allow_printing");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.EbookCourseMaterialDesc)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("ebook_course_material_desc");

                entity.Property(e => e.EbookCourseMaterialId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ebook_course_material_id");

                entity.Property(e => e.EbookUrn)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("ebook_urn");

                entity.Property(e => e.ExpiryDays).HasColumnName("expiry_days");
            });

            modelBuilder.Entity<EbookCourseMaterialsCustom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ebook_course_materials_custom");

                entity.Property(e => e.CompanyLogo)
                    .HasMaxLength(255)
                    .HasColumnName("company_logo");

                entity.Property(e => e.EbookCourseMaterialsCustomId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ebook_course_materials_custom_id");

                entity.Property(e => e.EbookTitle)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("ebook_title");

                entity.Property(e => e.EbookToken)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("ebook_token");

                entity.Property(e => e.EbookUrn)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("ebook_urn");
            });

            modelBuilder.Entity<EbookDownload>(entity =>
            {
                entity.ToTable("ebook_downloads");

                entity.Property(e => e.EbookDownloadId).HasColumnName("ebook_download_id");

                entity.Property(e => e.AllowDownload)
                    .IsRequired()
                    .HasColumnName("allow_download")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DownloadCount).HasColumnName("download_count");

                entity.Property(e => e.DownloadLink)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("download_link");

                entity.Property(e => e.EbookCourseMaterialId).HasColumnName("ebook_course_material_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<EbookDownloadsCustom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ebook_downloads_custom");

                entity.Property(e => e.EbookDownloadsCustomId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ebook_downloads_custom_id");

                entity.Property(e => e.EbookToken)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("ebook_token");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<EfTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EF_temp");

                entity.Property(e => e.CertReported)
                    .HasColumnType("datetime")
                    .HasColumnName("cert_reported");

                entity.Property(e => e.CompReported)
                    .HasColumnType("datetime")
                    .HasColumnName("comp_reported");

                entity.Property(e => e.McrReported)
                    .HasColumnType("datetime")
                    .HasColumnName("mcr_reported");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Reported)
                    .HasColumnType("datetime")
                    .HasColumnName("reported");
            });

            modelBuilder.Entity<Element>(entity =>
            {
                entity.HasKey(e => e.ElementId)
                    .HasName("PK87")
                    .IsClustered(false);

                entity.ToTable("element");

                entity.HasIndex(e => e.FmiUnitId, "IDX_fmi_unit_id");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.ElementRange)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("element_range");

                entity.Property(e => e.ElementRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("element_ref");

                entity.Property(e => e.ElementTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("element_title");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.HasOne(d => d.FmiUnit)
                    .WithMany(p => p.Elements)
                    .HasForeignKey(d => d.FmiUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reffmi_unit123");
            });

            modelBuilder.Entity<ElementJudgementComment>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.ElementId })
                    .HasName("PK_assessment_judgement_comments");

                entity.ToTable("element_judgement_comments");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.AssessmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("assessment_id");

                entity.Property(e => e.AssessorId).HasColumnName("assessor_id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .HasColumnName("comments");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Eligiblity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("eligiblity");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("age");

                entity.Property(e => e.AsylumSeeker).HasColumnName("asylum_seeker");

                entity.Property(e => e.Citizen).HasColumnName("citizen");

                entity.Property(e => e.Company)
                    .HasMaxLength(500)
                    .HasColumnName("company");

                entity.Property(e => e.Course)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("course");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Eligible).HasColumnName("eligible");

                entity.Property(e => e.EligiblePersonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EligiblePersonID");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.PermanentResident).HasColumnName("permanent_resident");

                entity.Property(e => e.ProtectionVisa).HasColumnName("protection_visa");

                entity.Property(e => e.Qualification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qualification");

                entity.Property(e => e.SpecialVisa).HasColumnName("special_visa");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emails");

                entity.Property(e => e.Body)
                    .IsUnicode(false)
                    .HasColumnName("body");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.EmailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("email_id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<EmailFormat>(entity =>
            {
                entity.ToTable("email_format");

                entity.Property(e => e.EmailFormatId).HasColumnName("email_format_id");

                entity.Property(e => e.EmailBottom).HasColumnName("email_bottom");

                entity.Property(e => e.EmailHead).HasColumnName("email_head");

                entity.Property(e => e.EmailSaved).HasColumnName("email_saved");

                entity.Property(e => e.EmailType)
                    .HasMaxLength(200)
                    .HasColumnName("email_type");

                entity.Property(e => e.Letter)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("letter");
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.HasKey(e => e.EmailLogId)
                    .HasName("PK_email_log_2__85")
                    .IsClustered(false);

                entity.ToTable("email_log");

                entity.Property(e => e.EmailLogId).HasColumnName("email_log_id");

                entity.Property(e => e.Body)
                    .IsUnicode(false)
                    .HasColumnName("body");

                entity.Property(e => e.BodyType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("body_type")
                    .HasDefaultValueSql("('TEXT')");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Recipient)
                    .IsUnicode(false)
                    .HasColumnName("recipient");

                entity.Property(e => e.Sender)
                    .IsUnicode(false)
                    .HasColumnName("sender");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sent_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Subject)
                    .IsUnicode(false)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<EmailLogAttach>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("email_log_attach");

                entity.Property(e => e.EmailLogAttachId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("email_log_attach_id");

                entity.Property(e => e.EmailLogId).HasColumnName("email_log_id");

                entity.Property(e => e.FileNameFullDb)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("file_name_full_DB");

                entity.Property(e => e.FileNameFullWs)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("file_name_full_WS");
            });

            modelBuilder.Entity<EmailResend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("email_resend");

                entity.Property(e => e.MailitemId).HasColumnName("mailitem_id");

                entity.Property(e => e.ResendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("resend_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EmailSubscribe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("email_subscribe");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
            });

            modelBuilder.Entity<EmailUnsubscribe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("email_unsubscribe");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
            });

            modelBuilder.Entity<EmpAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp_addresses");

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("address_line");

                entity.Property(e => e.AddressNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address_number");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("building");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.EmpAddressId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("emp_address_id");

                entity.Property(e => e.Line1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("line1");

                entity.Property(e => e.Line2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("line2");

                entity.Property(e => e.PostalBox)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("postal_box");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tag");

                entity.Property(e => e.Town)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("town");

                entity.Property(e => e.Unit)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("unit");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Work1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("work_1");
            });

            modelBuilder.Entity<Enrollee>(entity =>
            {
                entity.ToTable("enrollee");

                entity.HasIndex(e => e.FundingTypeId, "IDX_funding_type_id");

                entity.HasIndex(e => e.ParticipantId, "IDX_participant_id");

                entity.HasIndex(e => e.ProgramId, "IDX_program_id");

                entity.Property(e => e.EnrolleeId).HasColumnName("enrollee_id");

                entity.Property(e => e.AllowToEnrol).HasColumnName("allow_to_enrol");

                entity.Property(e => e.BacWageSubsidy).HasColumnName("bac_wage_subsidy");

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.CoachEmail)
                    .HasMaxLength(100)
                    .HasColumnName("coach_email");

                entity.Property(e => e.CoachFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("coach_first_name");

                entity.Property(e => e.CoachId).HasColumnName("coach_id");

                entity.Property(e => e.CoachLastName)
                    .HasMaxLength(50)
                    .HasColumnName("coach_last_name");

                entity.Property(e => e.CommencementDate)
                    .HasColumnType("datetime")
                    .HasColumnName("commencement_date");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CompanyHistoryId)
                    .HasColumnName("company_history_id")
                    .HasComment("Catscan company id");

                entity.Property(e => e.CompanyNameId).HasColumnName("company_name_id");

                entity.Property(e => e.CoursePart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_part");

                entity.Property(e => e.CourseResourceFeeOverride).HasColumnName("course_resource_fee_override");

                entity.Property(e => e.CourseResourceFeeOverrideSecondary).HasColumnName("course_resource_fee_override_secondary");

                entity.Property(e => e.DateGivenCertIfNotGrad)
                    .HasColumnType("datetime")
                    .HasColumnName("date_given_cert_if_not_grad");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.EnrolledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("enrolled_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnrolmentType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_type")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.ExpectedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expected_date");

                entity.Property(e => e.FacInvoiceLicenseeId).HasColumnName("fac_invoice_licensee_id");

                entity.Property(e => e.FederalFunding).HasColumnName("federal_funding");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.FormerLastName)
                    .HasMaxLength(50)
                    .HasColumnName("former_last_name");

                entity.Property(e => e.FundingTypeError).HasColumnName("funding_type_error");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.GovtContributionOverride).HasColumnName("Govt_Contribution_Override");

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("industry_code");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoice_date");

                entity.Property(e => e.IsVirtual).HasColumnName("is_virtual");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");

                entity.Property(e => e.MmCompany)
                    .HasMaxLength(100)
                    .HasColumnName("mm_company");

                entity.Property(e => e.MmEmail)
                    .HasMaxLength(100)
                    .HasColumnName("mm_email");

                entity.Property(e => e.MmFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("mm_first_name");

                entity.Property(e => e.MmLastName)
                    .HasMaxLength(50)
                    .HasColumnName("mm_last_name");

                entity.Property(e => e.NewAccount).HasColumnName("new_account");

                entity.Property(e => e.NominatedWelcomeEmail)
                    .HasColumnType("datetime")
                    .HasColumnName("nominated_welcome_email");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasColumnName("notes");

                entity.Property(e => e.OldLicenseeId)
                    .HasColumnName("old_licensee_id")
                    .HasComment("Column can be deleted after 01/07/2010");

                entity.Property(e => e.OverrideLocationId).HasColumnName("override_location_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PerfPack).HasColumnName("perf_pack");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Push)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("PUSH");

                entity.Property(e => e.QualificationFlag)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qualification_flag");

                entity.Property(e => e.RefUserId).HasColumnName("ref_user_id");

                entity.Property(e => e.ReportTo).HasColumnName("report_to");

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.SaleTypeId).HasColumnName("sale_type_id");

                entity.Property(e => e.SalesPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sales_person");

                entity.Property(e => e.TrainingOccursAtWorkplace).HasColumnName("training_occurs_at_workplace");

                entity.Property(e => e.TuitionFee).HasColumnName("tuition_fee");

                entity.Property(e => e.TuitionFeeHourOverride)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("tuition_fee_hour_override");

                entity.Property(e => e.UnitSignoffMm1Obsvr2ElseNull).HasColumnName("unit_signoff_mm1_obsvr2_else_null");

                entity.Property(e => e.UpgradeToFullQual)
                    .HasColumnType("datetime")
                    .HasColumnName("upgrade_to_full_qual");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.VettrakId)
                    .HasMaxLength(1024)
                    .HasColumnName("vettrak_id");

                entity.Property(e => e.XxxcatscanLicenseId)
                    .HasColumnName("xxxcatscan_license_id")
                    .HasComment("Column can be deleted after 01/07/2010");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Enrollees)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_enrollee_program");
            });

            modelBuilder.Entity<EnrolmentForm>(entity =>
            {
                entity.ToTable("enrolment_form");

                entity.HasIndex(e => e.ParticipantId, "IDX_participant_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(500)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(500)
                    .HasColumnName("address2");

                entity.Property(e => e.AdminComments)
                    .HasMaxLength(4000)
                    .HasColumnName("admin_comments");

                entity.Property(e => e.AdvDiploma)
                    .HasColumnName("adv_diploma")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvDiplomaTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("adv_diploma_title");

                entity.Property(e => e.AgreeWithAccessConditions)
                    .HasColumnType("datetime")
                    .HasColumnName("agree_with_access_conditions");

                entity.Property(e => e.AnzscoCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("anzsco_code");

                entity.Property(e => e.ApprenticeshipsCi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("apprenticeships_CI");

                entity.Property(e => e.ApprenticeshipsTci)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("apprenticeships_TCI");

                entity.Property(e => e.AtSchool).HasColumnName("at_school");

                entity.Property(e => e.CdfDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cdf_date");

                entity.Property(e => e.CertI)
                    .HasColumnName("cert_i")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CertITitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cert_i_title");

                entity.Property(e => e.CertIi)
                    .HasColumnName("cert_ii")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CertIiTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cert_ii_title");

                entity.Property(e => e.CertIii)
                    .HasColumnName("cert_iii")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CertIiiFromHighSchool).HasColumnName("cert_iii_from_high_school");

                entity.Property(e => e.CertIiiGuaranteeAgreed).HasColumnName("cert_iii_guarantee_agreed");

                entity.Property(e => e.CertIiiGuaranteeSheetRead).HasColumnName("cert_iii_guarantee_sheet_read");

                entity.Property(e => e.CertIiiTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cert_iii_title");

                entity.Property(e => e.CertIv)
                    .HasColumnName("cert_iv")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CertIvTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cert_iv_title");

                entity.Property(e => e.CertOther)
                    .HasColumnName("cert_other")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CertOtherTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cert_other_title");

                entity.Property(e => e.CertReported)
                    .HasColumnType("datetime")
                    .HasColumnName("cert_reported");

                entity.Property(e => e.CityTownBornIn)
                    .HasMaxLength(80)
                    .HasColumnName("city_town_born_in");

                entity.Property(e => e.CodeOfPracticeAccessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("code_of_practice_access_date");

                entity.Property(e => e.CompReported)
                    .HasColumnType("datetime")
                    .HasColumnName("comp_reported");

                entity.Property(e => e.CompletionsReport)
                    .HasColumnType("datetime")
                    .HasColumnName("completions_report");

                entity.Property(e => e.ComplianceNotes)
                    .HasMaxLength(4000)
                    .HasColumnName("compliance_notes");

                entity.Property(e => e.ConcessionHealthCare).HasColumnName("concession_health_care");

                entity.Property(e => e.ConcessionPensioner).HasColumnName("concession_pensioner");

                entity.Property(e => e.ConcessionVeteransGold).HasColumnName("concession_veterans_gold");

                entity.Property(e => e.ContractStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("contract_start_date");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.CourseBrochureAccessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("course_brochure_access_date");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CourseSiteId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("course_site_id");

                entity.Property(e => e.CourseSuitabilityReviewReminderEmail)
                    .HasColumnType("datetime")
                    .HasColumnName("Course_suitability_review_reminder_email");

                entity.Property(e => e.CourseSuitable).HasColumnName("course_suitable");

                entity.Property(e => e.CourseSuitableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("course_suitable_date");

                entity.Property(e => e.CourseSuitableUserId).HasColumnName("course_suitable_user_id");

                entity.Property(e => e.CreditTransfer)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("credit_transfer");

                entity.Property(e => e.CurrentlyEnrolledAdvDiplomaTitle)
                    .HasMaxLength(100)
                    .HasColumnName("currently_enrolled_adv_diploma_title");

                entity.Property(e => e.CurrentlyEnrolledCertITitle)
                    .HasMaxLength(100)
                    .HasColumnName("currently_enrolled_cert_i_title");

                entity.Property(e => e.CurrentlyEnrolledCertIiTitle)
                    .HasMaxLength(100)
                    .HasColumnName("currently_enrolled_cert_ii_title");

                entity.Property(e => e.CurrentlyEnrolledCertIiiTitle)
                    .HasMaxLength(100)
                    .HasColumnName("currently_enrolled_cert_iii_title");

                entity.Property(e => e.CurrentlyEnrolledCertIvTitle)
                    .HasMaxLength(100)
                    .HasColumnName("currently_enrolled_cert_iv_title");

                entity.Property(e => e.CurrentlyEnrolledCertOtherTitle)
                    .HasMaxLength(100)
                    .HasColumnName("currently_enrolled_cert_other_title");

                entity.Property(e => e.CurrentlyEnrolledDegreeTitle)
                    .HasMaxLength(100)
                    .HasColumnName("currently_enrolled_degree_title");

                entity.Property(e => e.CurrentlyEnrolledDiplomaTitle)
                    .HasMaxLength(100)
                    .HasColumnName("currently_enrolled_diploma_title");

                entity.Property(e => e.CurrentlyEnrolledEducation).HasColumnName("currently_enrolled_education");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Degree)
                    .HasColumnName("degree")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DegreeTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("degree_title");

                entity.Property(e => e.DetailsCorrect).HasColumnName("details_correct");

                entity.Property(e => e.Diploma)
                    .HasColumnName("diploma")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiplomaTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("diploma_title");

                entity.Property(e => e.DisabilityAbi)
                    .HasColumnName("disability_abi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisabilityAssistance).HasColumnName("disability_assistance");

                entity.Property(e => e.DisabilityAssistanceComments)
                    .HasMaxLength(4000)
                    .HasColumnName("disability_assistance_comments");

                entity.Property(e => e.DisabilityHearing)
                    .HasColumnName("disability_hearing")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisabilityIntellectual)
                    .HasColumnName("disability_intellectual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisabilityLearning)
                    .HasColumnName("disability_learning")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisabilityMedical)
                    .HasColumnName("disability_medical")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisabilityMental)
                    .HasColumnName("disability_mental")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisabilityOther)
                    .HasColumnName("disability_other")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisabilityPhysical)
                    .HasColumnName("disability_physical")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisabilityVision)
                    .HasColumnName("disability_vision")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Disable).HasColumnName("disable");

                entity.Property(e => e.DoNotReport).HasColumnName("do_not_report");

                entity.Property(e => e.Eligibility).HasColumnName("eligibility");

                entity.Property(e => e.EligibilityApproved)
                    .HasColumnType("datetime")
                    .HasColumnName("eligibility_approved");

                entity.Property(e => e.EmailPrimary)
                    .HasMaxLength(200)
                    .HasColumnName("email_primary");

                entity.Property(e => e.EmailSecondary)
                    .HasMaxLength(200)
                    .HasColumnName("email_secondary");

                entity.Property(e => e.EmployerPostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employer_postcode");

                entity.Property(e => e.EmployerSuburb)
                    .HasMaxLength(50)
                    .HasColumnName("employer_suburb");

                entity.Property(e => e.EnglishAssistance).HasColumnName("english_assistance");

                entity.Property(e => e.EnglishAssistanceComments)
                    .HasMaxLength(4000)
                    .HasColumnName("english_assistance_comments");

                entity.Property(e => e.EnrolmentAccepted)
                    .HasColumnType("datetime")
                    .HasColumnName("enrolment_accepted");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.FormCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("form_completed");

                entity.Property(e => e.FundingEligibilityKey)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("funding_eligibility_key");

                entity.Property(e => e.FundingExplained).HasColumnName("funding_explained");

                entity.Property(e => e.FundingInformationAccessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("funding_information_access_date");

                entity.Property(e => e.FundingSourceNationalIdentifier).HasColumnName("Funding_Source_National_Identifier");

                entity.Property(e => e.HaveReadVetNotice).HasColumnName("have_read_VET_notice");

                entity.Property(e => e.HighestSchool)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("highest_school")
                    .IsFixedLength(true);

                entity.Property(e => e.IncludeInNatFilesIfNoTp).HasColumnName("include_in_NAT_files_if_no_TP");

                entity.Property(e => e.Indigeneous)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("indigeneous")
                    .IsFixedLength(true);

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("industry_code");

                entity.Property(e => e.IndustryStartYear).HasColumnName("industry_start_year");

                entity.Property(e => e.InformedReFutureImpact)
                    .HasColumnType("datetime")
                    .HasColumnName("informed_re_future_impact");

                entity.Property(e => e.LabourForceStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("labour_force_status")
                    .IsFixedLength(true);

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .HasColumnName("language");

                entity.Property(e => e.LanguageCode).HasColumnName("language_code");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated");

                entity.Property(e => e.LlnInadequateReviewReminderEmail)
                    .HasColumnType("datetime")
                    .HasColumnName("LLN_inadequate_review_reminder_email");

                entity.Property(e => e.LlnOk).HasColumnName("LLN_ok");

                entity.Property(e => e.LlnOkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LLN_ok_date");

                entity.Property(e => e.LlnOkUserId).HasColumnName("LLN_ok_user_id");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.McrReported)
                    .HasColumnType("datetime")
                    .HasColumnName("mcr_reported");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("middle_name");

                entity.Property(e => e.NoSchoolTraining).HasColumnName("no_school_training");

                entity.Property(e => e.NomCompletionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("nom_completion_date");

                entity.Property(e => e.NswCommitmentId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NSW_commitment_id");

                entity.Property(e => e.NswSsContactDetailsProvided)
                    .HasColumnType("datetime")
                    .HasColumnName("NSW_SS_contact_details_provided");

                entity.Property(e => e.OtherCountries)
                    .HasMaxLength(100)
                    .HasColumnName("Other_countries");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_home");

                entity.Property(e => e.PhoneMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_mobile");

                entity.Property(e => e.PhoneWork)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_work");

                entity.Property(e => e.PoBox)
                    .HasMaxLength(250)
                    .HasColumnName("PO_box");

                entity.Property(e => e.PostalBuildingName)
                    .HasMaxLength(250)
                    .HasColumnName("postal_building_name");

                entity.Property(e => e.PostalPostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("postal_postcode");

                entity.Property(e => e.PostalState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("postal_state")
                    .IsFixedLength(true);

                entity.Property(e => e.PostalStreetName)
                    .HasMaxLength(250)
                    .HasColumnName("postal_street_name");

                entity.Property(e => e.PostalStreetNumber)
                    .HasMaxLength(250)
                    .HasColumnName("postal_street_number");

                entity.Property(e => e.PostalSuburb)
                    .HasMaxLength(50)
                    .HasColumnName("postal_suburb");

                entity.Property(e => e.PostalUnitDetails)
                    .HasMaxLength(250)
                    .HasColumnName("postal_unit_details");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.PriorEducation).HasColumnName("prior_education");

                entity.Property(e => e.PrivacyAgreement)
                    .HasColumnName("privacy_agreement")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Proficiency).HasColumnName("proficiency");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.PtrCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("PTR_completed");

                entity.Property(e => e.QualCancellationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("qual_cancellation_date");

                entity.Property(e => e.QualCompletionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("qual_completion_date");

                entity.Property(e => e.QualsCorrect).HasColumnName("quals_correct");

                entity.Property(e => e.RecordCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("record_created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reported)
                    .HasColumnType("datetime")
                    .HasColumnName("reported");

                entity.Property(e => e.ResidentType).HasColumnName("resident_type");

                entity.Property(e => e.ResidentialBuildingName)
                    .HasMaxLength(250)
                    .HasColumnName("residential_building_name");

                entity.Property(e => e.ResidentialState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("residential_state")
                    .IsFixedLength(true);

                entity.Property(e => e.ResidentialStreetName)
                    .HasMaxLength(250)
                    .HasColumnName("residential_street_name");

                entity.Property(e => e.ResidentialStreetNumber)
                    .HasMaxLength(250)
                    .HasColumnName("residential_street_number");

                entity.Property(e => e.ResidentialUnitDetails)
                    .HasMaxLength(250)
                    .HasColumnName("residential_unit_details");

                entity.Property(e => e.Rpl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rpl");

                entity.Property(e => e.Rto)
                    .HasMaxLength(4000)
                    .HasColumnName("rto");

                entity.Property(e => e.S4aNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("s4a_number");

                entity.Property(e => e.School)
                    .HasMaxLength(4000)
                    .HasColumnName("school");

                entity.Property(e => e.SecQualCancellationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sec_qual_cancellation_date");

                entity.Property(e => e.SecQualCompletionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sec_qual_completion_date");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex")
                    .IsFixedLength(true);

                entity.Property(e => e.SffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sff_date");

                entity.Property(e => e.StudyReason)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("study_reason")
                    .IsFixedLength(true);

                entity.Property(e => e.Support).HasColumnName("support");

                entity.Property(e => e.SupportComments)
                    .HasMaxLength(4000)
                    .HasColumnName("support_comments");

                entity.Property(e => e.SurveyContactStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("survey_contact_status")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.TraineeshipQual).HasColumnName("traineeship_qual");

                entity.Property(e => e.TrainingContractNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("training_contract_number");

                entity.Property(e => e.TrainingEmploymentSurveyAgreed).HasColumnName("training_employment_survey_agreed");

                entity.Property(e => e.TrsNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("trs_number");

                entity.Property(e => e.UniqueStudentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unique_student_identifier");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UsiLocateConsent).HasColumnName("USI_locate_consent");

                entity.Property(e => e.VictorianStudentNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("victorian_student_number");

                entity.Property(e => e.WorkSa).HasColumnName("work_sa");

                entity.Property(e => e.YearHighestSchool)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("year_highest_school")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<EnrolmentFormAdditional>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("enrolment_form_additional");

                entity.Property(e => e.EnrolFormAdditionalId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EnrolFormAdditionalID");

                entity.Property(e => e.GroupNoIsPrevious).HasColumnName("GroupNo_IsPrevious");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Insert_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnrolmentFormNz>(entity =>
            {
                entity.ToTable("enrolment_form_nz");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(2000)
                    .HasColumnName("address");

                entity.Property(e => e.AddressIsCompany).HasColumnName("address_is_company");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.EthnicGroup)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ethnic_group");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .HasColumnName("last_name");

                entity.Property(e => e.NsnNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nsn_number");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PrivacyAgreement)
                    .HasColumnType("datetime")
                    .HasColumnName("privacy_agreement");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.ToTable("event_type");

                entity.Property(e => e.EventTypeId).HasColumnName("event_type_id");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("event_name");
            });

            modelBuilder.Entity<ExpectedEnrolment>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.Quantity, e.CatscanLicenseId });

                entity.ToTable("expected_enrolments");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.CatscanLicenseId).HasColumnName("catscan_license_id");

                entity.Property(e => e.ExpectedEnrolmentsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("expected_enrolments_id");
            });

            modelBuilder.Entity<ExtractAuditType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("extract_audit_type");

                entity.HasIndex(e => e.ExtractAuditTypeId, "IX_extract_audit_type")
                    .IsUnique();

                entity.Property(e => e.ExtractAuditType1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("extract_audit_type");

                entity.Property(e => e.ExtractAuditTypeId).HasColumnName("extract_audit_type_id");

                entity.Property(e => e.IsEmailSend).HasColumnName("is_email_send");

                entity.Property(e => e.SpName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("sp_name");

                entity.Property(e => e.UseBatchOrHeaderId).HasColumnName("use_batch_or_header_id");
            });

            modelBuilder.Entity<ExtractDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("extract_details");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.ApprenticeshipsCi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("apprenticeships_CI");

                entity.Property(e => e.ApprenticeshipsTci)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("apprenticeships_TCI");

                entity.Property(e => e.AttendedHours).HasColumnName("attended_hours");

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.CaDateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("CA_date_achieved");

                entity.Property(e => e.CertReported)
                    .HasColumnType("datetime")
                    .HasColumnName("cert_reported");

                entity.Property(e => e.CertificateIssuedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_issued_date");

                entity.Property(e => e.CompReported)
                    .HasColumnType("datetime")
                    .HasColumnName("comp_reported");

                entity.Property(e => e.CourseCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CourseSiteId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("course_site_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.DiscontinuedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("discontinued_date");

                entity.Property(e => e.EnrolledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("enrolled_date");

                entity.Property(e => e.ExtendAccess)
                    .HasColumnType("datetime")
                    .HasColumnName("extend_access");

                entity.Property(e => e.ExtractDetailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("extract_detail_id");

                entity.Property(e => e.ExtractHeaderId).HasColumnName("extract_header_id");

                entity.Property(e => e.FmiUnitCode)
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FundingTypeError).HasColumnName("funding_type_error");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.M1Date)
                    .HasColumnType("datetime")
                    .HasColumnName("M1_date");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.MaxWorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("max_workshop_date");

                entity.Property(e => e.MaxWorkshopDateBeforeGetDateUsed)
                    .HasColumnType("datetime")
                    .HasColumnName("Max_workshop_date_before_GetDateUsed");

                entity.Property(e => e.NswCommitmentId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NSW_commitment_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PCertificateIssuedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("P_certificate_issued_date");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PcDateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("PC_date_achieved");

                entity.Property(e => e.PcEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PC_end_date");

                entity.Property(e => e.PcEvidenceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PC_evidence_date");

                entity.Property(e => e.PcStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PC_start_date");

                entity.Property(e => e.PctrFundingReported)
                    .HasColumnType("datetime")
                    .HasColumnName("PCTR_funding_reported");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.RplCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RPL_create_date");

                entity.Property(e => e.StudyReason)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("study_reason")
                    .IsFixedLength(true);

                entity.Property(e => e.TuitionFee).HasColumnName("tuition_fee");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.VettrakId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VETtrak_id");
            });

            modelBuilder.Entity<ExtractExclude>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("extract_exclude");

                entity.Property(e => e.ExcludeUntilDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exclude_until_date");

                entity.Property(e => e.ExtractExcludeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("extract_exclude_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<ExtractHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("extract_header");

                entity.Property(e => e.ExtractHeaderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("extract_header_id");

                entity.Property(e => e.ExtractStart)
                    .HasColumnType("datetime")
                    .HasColumnName("extract_start");

                entity.Property(e => e.ExtractTypeId).HasColumnName("extract_type_id");

                entity.Property(e => e.GetDateUsed)
                    .HasColumnType("datetime")
                    .HasColumnName("get_date_used");
            });

            modelBuilder.Entity<ExtractTag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("extract_tags");

                entity.Property(e => e.ExtractTag1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extract_tag");

                entity.Property(e => e.ExtractTagId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("extract_tag_id");

                entity.Property(e => e.ExtractTagScopeExtractId).HasColumnName("extract_tag_scope_extract_id");

                entity.Property(e => e.ExtractTageDescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("extract_tage_description");
            });

            modelBuilder.Entity<ExtractTracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("extract_tracking");

                entity.Property(e => e.ExtractHeaderId).HasColumnName("extract_header_id");

                entity.Property(e => e.ExtractTrackingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ExtractTrackingID");

                entity.Property(e => e.InsertedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("inserted_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("new_value");

                entity.Property(e => e.OtherId).HasColumnName("other_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PreviousValue)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("previous_value");

                entity.Property(e => e.SubPartId).HasColumnName("sub_part_id");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<Facilitator>(entity =>
            {
                entity.ToTable("facilitators");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.FacId).HasColumnName("fac_id");

                entity.Property(e => e.FacLevel).HasColumnName("fac_level");
            });

            modelBuilder.Entity<FacilitatorComment>(entity =>
            {
                entity.HasKey(e => e.FacilitatorCommentId)
                    .HasName("PK62facilitator_comments")
                    .IsClustered(false);

                entity.ToTable("facilitator_comments");

                entity.Property(e => e.FacilitatorCommentId).HasColumnName("facilitator_comment_id");

                entity.Property(e => e.FacilitatorComment1)
                    .HasMaxLength(1200)
                    .IsUnicode(false)
                    .HasColumnName("facilitator_comment");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FacilitatorComments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers84");
            });

            modelBuilder.Entity<FacilitatorInvoice>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.ParticipantId });

                entity.ToTable("facilitator_invoice");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.M1).HasColumnName("m1");

                entity.Property(e => e.Mcr).HasColumnName("mcr");

                entity.Property(e => e.Resit).HasColumnName("resit");
            });

            modelBuilder.Entity<FboltoAct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FBOLtoACT");

                entity.Property(e => e.CertIssued)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cert_issued");

                entity.Property(e => e.CoachCombinedName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("coach_combined_name");

                entity.Property(e => e.CoachUserId).HasColumnName("coach_user_id");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_code");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.Licensee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("licensee");

                entity.Property(e => e.MmBusinessPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_business_phone");

                entity.Property(e => e.MmCombinedName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_combined_name");

                entity.Property(e => e.MmCompany)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_company");

                entity.Property(e => e.MmCompanyAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_add1");

                entity.Property(e => e.MmCompanyAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_add2");

                entity.Property(e => e.MmCompanyCity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_city");

                entity.Property(e => e.MmCompanyPostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_postcode");

                entity.Property(e => e.MmCompanyState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_state");

                entity.Property(e => e.MmDob)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_dob");

                entity.Property(e => e.MmEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_email");

                entity.Property(e => e.MmFax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_fax");

                entity.Property(e => e.MmFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mm_first_name");

                entity.Property(e => e.MmHomeAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_add1");

                entity.Property(e => e.MmHomeAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_add2");

                entity.Property(e => e.MmHomeCity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_city");

                entity.Property(e => e.MmHomePostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_postcode");

                entity.Property(e => e.MmHomeState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_state");

                entity.Property(e => e.MmLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mm_last_name");

                entity.Property(e => e.MmMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_mobile");

                entity.Property(e => e.MmPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_phone");

                entity.Property(e => e.MmRecord).HasColumnName("mm_record#");

                entity.Property(e => e.MmUserId).HasColumnName("mm_user_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PartBusinessPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_business_phone");

                entity.Property(e => e.PartCompany)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_company");

                entity.Property(e => e.PartCompanyAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_company_add1");

                entity.Property(e => e.PartCompanyAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_company_add2");

                entity.Property(e => e.PartCompanyCity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_company_city");

                entity.Property(e => e.PartCompanyPostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_company_postcode");

                entity.Property(e => e.PartCompanyState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_company_state");

                entity.Property(e => e.PartDob)
                    .HasColumnType("datetime")
                    .HasColumnName("part_dob");

                entity.Property(e => e.PartEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_email");

                entity.Property(e => e.PartFax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_fax");

                entity.Property(e => e.PartFirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_first_name");

                entity.Property(e => e.PartHomeAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_home_add1");

                entity.Property(e => e.PartHomeAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_home_add2");

                entity.Property(e => e.PartHomeCity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_home_city");

                entity.Property(e => e.PartHomePostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_home_postcode");

                entity.Property(e => e.PartHomeState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_home_state");

                entity.Property(e => e.PartId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_id");

                entity.Property(e => e.PartLastName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_last_name");

                entity.Property(e => e.PartMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_mobile");

                entity.Property(e => e.PartName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_name");

                entity.Property(e => e.PartPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_phone");

                entity.Property(e => e.PartRecord).HasColumnName("part_record#");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<FboltoCrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FBOLtoCRM");

                entity.Property(e => e.CertIssued)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cert_issued");

                entity.Property(e => e.CoachCombinedName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("coach_combined_name");

                entity.Property(e => e.CoachUserId).HasColumnName("coach_user_id");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_code");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("job_title");

                entity.Property(e => e.Licensee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("licensee");

                entity.Property(e => e.MmBusinessPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_business_phone");

                entity.Property(e => e.MmCombinedName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_combined_name");

                entity.Property(e => e.MmCompany)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_company");

                entity.Property(e => e.MmCompanyAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_add1");

                entity.Property(e => e.MmCompanyAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_add2");

                entity.Property(e => e.MmCompanyCity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_city");

                entity.Property(e => e.MmCompanyPostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_postcode");

                entity.Property(e => e.MmCompanyState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_company_state");

                entity.Property(e => e.MmDob)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_dob");

                entity.Property(e => e.MmEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_email");

                entity.Property(e => e.MmFax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_fax");

                entity.Property(e => e.MmFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mm_first_name");

                entity.Property(e => e.MmHomeAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_add1");

                entity.Property(e => e.MmHomeAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_add2");

                entity.Property(e => e.MmHomeCity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_city");

                entity.Property(e => e.MmHomePostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_postcode");

                entity.Property(e => e.MmHomeState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_home_state");

                entity.Property(e => e.MmLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mm_last_name");

                entity.Property(e => e.MmMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_mobile");

                entity.Property(e => e.MmPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mm_phone");

                entity.Property(e => e.MmRecord).HasColumnName("mm_record#");

                entity.Property(e => e.MmUserId).HasColumnName("mm_user_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PartBusinessPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_business_phone");

                entity.Property(e => e.PartCompany)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_company");

                entity.Property(e => e.PartCompanyAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_company_add1");

                entity.Property(e => e.PartCompanyAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_company_add2");

                entity.Property(e => e.PartCompanyCity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_company_city");

                entity.Property(e => e.PartCompanyPostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_company_postcode");

                entity.Property(e => e.PartCompanyState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_company_state");

                entity.Property(e => e.PartDob)
                    .HasColumnType("datetime")
                    .HasColumnName("part_dob");

                entity.Property(e => e.PartEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_email");

                entity.Property(e => e.PartFax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_fax");

                entity.Property(e => e.PartFirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_first_name");

                entity.Property(e => e.PartHomeAdd1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_home_add1");

                entity.Property(e => e.PartHomeAdd2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_home_add2");

                entity.Property(e => e.PartHomeCity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_home_city");

                entity.Property(e => e.PartHomePostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_home_postcode");

                entity.Property(e => e.PartHomeState)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_home_state");

                entity.Property(e => e.PartId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_id");

                entity.Property(e => e.PartLastName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_last_name");

                entity.Property(e => e.PartMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_mobile");

                entity.Property(e => e.PartName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("part_name");

                entity.Property(e => e.PartPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part_phone");

                entity.Property(e => e.PartRecord).HasColumnName("part_record#");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.StateCode).HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("feedback");

                entity.HasIndex(e => new { e.WorkshopId, e.ParticipantId }, "PK7")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ContractScore)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("contract_score");

                entity.Property(e => e.FeedbackDate)
                    .HasColumnType("datetime")
                    .HasColumnName("feedback_date");

                entity.Property(e => e.LearningOutcomeMet).HasColumnName("learning_outcome_met");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<FeedbackQuestionResponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("feedback_question_response");

                entity.HasIndex(e => new { e.WorkshopId, e.ParticipantId, e.LessonQuestionId }, "PK19")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.LessonQuestionId, "feedback_question_response1")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.LastEdited)
                    .HasColumnType("datetime")
                    .HasColumnName("last_edited");

                entity.Property(e => e.LessonQuestionId).HasColumnName("lesson_question_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Response)
                    .HasMaxLength(1000)
                    .HasColumnName("response");

                entity.Property(e => e.Verified).HasColumnName("verified");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<FfsOnly>(entity =>
            {
                entity.HasKey(e => new { e.FmiUnitId, e.CourseId, e.MappingId, e.FundingTypeId })
                    .HasName("PK_FFS_only");

                entity.ToTable("ffs_only");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");
            });

            modelBuilder.Entity<FileNote>(entity =>
            {
                entity.ToTable("file_note");

                entity.Property(e => e.FileNoteId).HasColumnName("file_note_id");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note)
                    .HasMaxLength(4000)
                    .HasColumnName("note");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1000)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<FmiMatrix>(entity =>
            {
                entity.HasKey(e => new { e.LessonId, e.FmiUnitId })
                    .HasName("PK76")
                    .IsClustered(false);

                entity.ToTable("fmi_matrix");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.HasOne(d => d.FmiUnit)
                    .WithMany(p => p.FmiMatrices)
                    .HasForeignKey(d => d.FmiUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__fmi_matri__fmi_u__33008CF0");
            });

            modelBuilder.Entity<FmiReplacement>(entity =>
            {
                entity.HasKey(e => new { e.FmiUnitId, e.OldFmiUnitId });

                entity.ToTable("fmi_replacement");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.OldFmiUnitId).HasColumnName("old_fmi_unit_id");

                entity.Property(e => e.SameMapping).HasColumnName("same_mapping");
            });

            modelBuilder.Entity<FmiUnit>(entity =>
            {
                entity.HasKey(e => e.FmiUnitId)
                    .HasName("PK77")
                    .IsClustered(false);

                entity.ToTable("fmi_unit");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitDesc)
                    .HasMaxLength(1000)
                    .HasColumnName("fmi_unit_desc");

                entity.Property(e => e.FmiUnitTitle)
                    .HasMaxLength(100)
                    .HasColumnName("fmi_unit_title");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FmiUnitChangeHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fmi_unit_change_history");

                entity.Property(e => e.ActiveFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("active_from");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FmiUnitIdNew).HasColumnName("fmi_unit_id_New");

                entity.Property(e => e.FmiUnitUid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fmi_unit_UID");
            });

            modelBuilder.Entity<Funding>(entity =>
            {
                entity.HasKey(e => e.ParticipantId);

                entity.ToTable("funding");

                entity.Property(e => e.ParticipantId)
                    .ValueGeneratedNever()
                    .HasColumnName("participant_id");

                entity.Property(e => e.ClientAmount).HasColumnName("client_amount");

                entity.Property(e => e.ClientPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("client_paid");

                entity.Property(e => e.CourseDetailsForm)
                    .HasColumnType("datetime")
                    .HasColumnName("course_details_form");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("invoice_issued");

                entity.Property(e => e.InvoiceNo).HasColumnName("invoiceNo");

                entity.Property(e => e.InvoiceRequestId).HasColumnName("invoice_request_id");

                entity.Property(e => e.LicenseeFundingAmount).HasColumnName("licensee_funding_amount");

                entity.Property(e => e.LicenseeUpfrontAmount).HasColumnName("licensee_upfront_amount");

                entity.Property(e => e.LicenseeUpfrontPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("licensee_upfront_paid");

                entity.Property(e => e.PurchaseLevel).HasColumnName("purchase_level");

                entity.Property(e => e.ReferralForm)
                    .HasColumnType("datetime")
                    .HasColumnName("referral_form");

                entity.Property(e => e.StockDispatched)
                    .HasColumnType("datetime")
                    .HasColumnName("stock_dispatched");

                entity.Property(e => e.TotalFunding).HasColumnName("total_funding");

                entity.Property(e => e.TrainingPlan)
                    .HasColumnType("datetime")
                    .HasColumnName("training_plan");
            });

            modelBuilder.Entity<FundingAdjustment>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceRequestId, e.UserId, e.ParticipantId })
                    .HasName("PK_funding_adjustments_1");

                entity.ToTable("funding_adjustments");

                entity.Property(e => e.InvoiceRequestId).HasColumnName("invoice_request_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .HasColumnName("comments");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Difference)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("difference");

                entity.Property(e => e.FundingAdjustmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("funding_adjustment_id");
            });

            modelBuilder.Entity<FundingImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("funding_import");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClaimHours).HasColumnName("claim_hours");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FundingImportId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("funding_import_id");

                entity.Property(e => e.PaymentMonth)
                    .HasColumnType("datetime")
                    .HasColumnName("payment_month");

                entity.Property(e => e.QualCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qual_code");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<FundingInvoiceRequest>(entity =>
            {
                entity.HasKey(e => e.InvoiceRequestId);

                entity.ToTable("funding_invoice_request");

                entity.Property(e => e.InvoiceRequestId).HasColumnName("invoice_request_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Licensee).HasColumnName("licensee");

                entity.Property(e => e.PaidDate)
                    .HasColumnType("datetime")
                    .HasColumnName("paid_date");
            });

            modelBuilder.Entity<FundingInvoiceRequestBackup>(entity =>
            {
                entity.HasKey(e => e.InvoiceRequestId);

                entity.ToTable("funding_invoice_request_backup");

                entity.Property(e => e.InvoiceRequestId).HasColumnName("invoice_request_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Licensee).HasColumnName("licensee");
            });

            modelBuilder.Entity<FundingParticipantStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Funding_Participant_Status");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.DiscontinuedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("discontinued_date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.FundingType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("funding_type");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .HasColumnName("location_name");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Reported)
                    .HasColumnType("datetime")
                    .HasColumnName("reported");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<FundingRate>(entity =>
            {
                entity.HasKey(e => new { e.StartDate, e.QualificationId });

                entity.ToTable("funding_rates");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.MaxHours).HasColumnName("max_hours");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.RegionalRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("regional_rate");

                entity.Property(e => e.RplMultiplier)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rpl_multiplier");

                entity.Property(e => e.SspTuitionFee).HasColumnName("ssp_tuition_fee");

                entity.Property(e => e.StartOnCcDate).HasColumnName("start_on_cc_date");

                entity.Property(e => e.VtgTuitionFeeHour)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vtg_tuition_fee_hour");
            });

            modelBuilder.Entity<FundingRatesBackup>(entity =>
            {
                entity.HasKey(e => new { e.StartDate, e.CourseId, e.CoursePart });

                entity.ToTable("funding_rates_backup");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CoursePart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_part");

                entity.Property(e => e.ClientUpfront).HasColumnName("client_upfront");

                entity.Property(e => e.ClientUpfrontPp).HasColumnName("client_upfront_pp");

                entity.Property(e => e.LicenseeFunding).HasColumnName("licensee_funding");

                entity.Property(e => e.LicenseeFundingAddL2).HasColumnName("licensee_funding_add_L2");

                entity.Property(e => e.LicenseeFundingAddL3).HasColumnName("licensee_funding_add_L3");

                entity.Property(e => e.LicenseeFundingPp).HasColumnName("licensee_funding_pp");

                entity.Property(e => e.LicenseeUpfront).HasColumnName("licensee_upfront");

                entity.Property(e => e.LicenseeUpfrontPp).HasColumnName("licensee_upfront_pp");

                entity.Property(e => e.SspTuitionFee).HasColumnName("ssp_tuition_fee");

                entity.Property(e => e.TotalFunding).HasColumnName("total_funding");

                entity.Property(e => e.VtgTuitionFeeHour)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vtg_tuition_fee_hour");
            });

            modelBuilder.Entity<FundingReceived>(entity =>
            {
                entity.ToTable("funding_received");

                entity.Property(e => e.FundingReceivedId).HasColumnName("funding_received_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CappedHours).HasColumnName("capped_hours");

                entity.Property(e => e.ClaimHours).HasColumnName("claim_hours");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FmiUnitCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.InvoiceRequestId).HasColumnName("invoice_request_id");

                entity.Property(e => e.LicenseeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("licensee_amount");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PaymentMonth)
                    .HasColumnType("datetime")
                    .HasColumnName("payment_month");

                entity.Property(e => e.QualCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qual_code");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.RateExpected)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate_expected");

                entity.Property(e => e.RatePaid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate_paid");

                entity.Property(e => e.RateVerified)
                    .HasColumnType("datetime")
                    .HasColumnName("rate_verified");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<FundingReceivedBackup>(entity =>
            {
                entity.HasKey(e => new { e.ClaimId, e.ReferenceNo });

                entity.ToTable("funding_received_backup");

                entity.Property(e => e.ClaimId).HasColumnName("claimId");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("referenceNo");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CalculatedLicenseeAmount).HasColumnName("calculated_licensee_amount");

                entity.Property(e => e.ClaimHours).HasColumnName("claimHours");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FmiUnitCode)
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.InvoiceRequestId).HasColumnName("invoice_request_id");

                entity.Property(e => e.LicenseeAmount).HasColumnName("licensee_amount");

                entity.Property(e => e.LicenseePaidDate)
                    .HasColumnType("datetime")
                    .HasColumnName("licensee_paid_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProcessedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("processedDate");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("studentName");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<FundingReceivedBackupForPeter>(entity =>
            {
                entity.HasKey(e => new { e.ClaimId, e.ReferenceNo })
                    .HasName("PK_funding_received");

                entity.ToTable("funding_received_backup_for_Peter");

                entity.Property(e => e.ClaimId).HasColumnName("claimId");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("referenceNo");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CappedHours).HasColumnName("capped_hours");

                entity.Property(e => e.ClaimHours).HasColumnName("claimHours");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FmiUnitCode)
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InvoiceRequestId).HasColumnName("invoice_request_id");

                entity.Property(e => e.LicenseeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("licensee_amount");

                entity.Property(e => e.LicenseePaidDate)
                    .HasColumnType("datetime")
                    .HasColumnName("licensee_paid_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProcessedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("processedDate");

                entity.Property(e => e.QualCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qual_code");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.RateExpected)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate_expected");

                entity.Property(e => e.RatePaid)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("rate_paid");

                entity.Property(e => e.SalesPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sales_person");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("studentName");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<FundingType>(entity =>
            {
                entity.ToTable("funding_type");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CombinedPending).HasColumnName("combined_pending");

                entity.Property(e => e.DualQualifications)
                    .HasColumnName("dual_qualifications")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FundingType1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("funding_type");

                entity.Property(e => e.FundingTypeAbbr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("funding_type_abbr");

                entity.Property(e => e.ReportTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("report_to");
            });

            modelBuilder.Entity<FundingTypeCourse>(entity =>
            {
                entity.ToTable("funding_type_course");

                entity.Property(e => e.FundingTypeCourseId).HasColumnName("funding_type_course_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FedFundingTypeId).HasColumnName("fed_funding_type_id");

                entity.Property(e => e.QualificationIdIfDual).HasColumnName("qualification_id_if_dual");
            });

            modelBuilder.Entity<FundingTypeFederal>(entity =>
            {
                entity.HasKey(e => e.FedFundingTypeId);

                entity.ToTable("funding_type_federal");

                entity.Property(e => e.FedFundingTypeId).HasColumnName("fed_funding_type_id");

                entity.Property(e => e.DualQualifications).HasColumnName("dual_qualifications");

                entity.Property(e => e.FedFundingType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fed_funding_type");

                entity.Property(e => e.FedFundingTypeAbbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fed_funding_type_abbr");
            });

            modelBuilder.Entity<GeneralComment>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.UserId, e.CommentDate })
                    .HasName("pk37_1")
                    .IsClustered(false);

                entity.ToTable("general_comment");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("comment");

                entity.Property(e => e.Section).HasColumnName("section");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.GeneralComments)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipant112");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GeneralComments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers113");
            });

            modelBuilder.Entity<Goal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("goal");

                entity.HasIndex(e => e.GoalId, "PK26")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.ParticipantId, e.IsWpp, e.GoalId }, "goal2")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AchievedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("achieved_date");

                entity.Property(e => e.AdditionalResources)
                    .HasMaxLength(2000)
                    .HasColumnName("additional_resources");

                entity.Property(e => e.Affirmation1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_1");

                entity.Property(e => e.Affirmation2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_2");

                entity.Property(e => e.Affirmation3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_3");

                entity.Property(e => e.Affirmation4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_4");

                entity.Property(e => e.Affirmation5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_5");

                entity.Property(e => e.Affirmation6)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_6");

                entity.Property(e => e.AreaOfLife)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("area_of_life");

                entity.Property(e => e.Benefits)
                    .HasMaxLength(2000)
                    .HasColumnName("benefits");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateArchived)
                    .HasColumnType("datetime")
                    .HasColumnName("date_archived");

                entity.Property(e => e.ExpectedSavings)
                    .HasMaxLength(2000)
                    .HasColumnName("expected_savings");

                entity.Property(e => e.Goal1)
                    .HasMaxLength(2000)
                    .HasColumnName("goal");

                entity.Property(e => e.GoalId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("goal_id");

                entity.Property(e => e.GoalOrig)
                    .HasMaxLength(2000)
                    .HasColumnName("goal_orig");

                entity.Property(e => e.GoalType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("goal_type")
                    .HasDefaultValueSql("('GOALS')");

                entity.Property(e => e.IsWpp)
                    .HasColumnName("is_wpp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Measurement)
                    .HasMaxLength(2000)
                    .HasColumnName("measurement");

                entity.Property(e => e.MeasurementOrig)
                    .HasMaxLength(2000)
                    .HasColumnName("measurement_orig");

                entity.Property(e => e.Obstacles)
                    .HasMaxLength(2000)
                    .HasColumnName("obstacles");

                entity.Property(e => e.OthersToNotify)
                    .HasMaxLength(2000)
                    .HasColumnName("others_to_notify");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ReportProgressTo)
                    .HasMaxLength(2000)
                    .HasColumnName("report_progress_to");

                entity.Property(e => e.Saved).HasColumnName("saved");

                entity.Property(e => e.Solutions)
                    .HasMaxLength(2000)
                    .HasColumnName("solutions");

                entity.Property(e => e.Supportvalues).HasColumnName("supportvalues");

                entity.Property(e => e.TargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("target_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Who)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("who");

                entity.Property(e => e.WorthIt).HasColumnName("worth_it");
            });

            modelBuilder.Entity<GoalUser>(entity =>
            {
                entity.HasKey(e => e.GoalId)
                    .HasName("PK26_1")
                    .IsClustered(false);

                entity.ToTable("goal_user");

                entity.HasIndex(e => new { e.UserId, e.GoalId }, "goal2_1")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.GoalId).HasColumnName("goal_id");

                entity.Property(e => e.AchievedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("achieved_date");

                entity.Property(e => e.Affirmation1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_1");

                entity.Property(e => e.Affirmation2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_2");

                entity.Property(e => e.Affirmation3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_3");

                entity.Property(e => e.Affirmation4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_4");

                entity.Property(e => e.Affirmation5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_5");

                entity.Property(e => e.Affirmation6)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("affirmation_6");

                entity.Property(e => e.Benefits)
                    .HasMaxLength(2000)
                    .HasColumnName("benefits");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Goal)
                    .HasMaxLength(2000)
                    .HasColumnName("goal");

                entity.Property(e => e.GoalType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("goal_type")
                    .HasDefaultValueSql("('GOALS')");

                entity.Property(e => e.Measurement)
                    .HasMaxLength(2000)
                    .HasColumnName("measurement");

                entity.Property(e => e.MeasurementOrig)
                    .HasMaxLength(2000)
                    .HasColumnName("measurement_orig");

                entity.Property(e => e.Obstacles)
                    .HasMaxLength(2000)
                    .HasColumnName("obstacles");

                entity.Property(e => e.Solutions)
                    .HasMaxLength(2000)
                    .HasColumnName("solutions");

                entity.Property(e => e.Supportvalues).HasColumnName("supportvalues");

                entity.Property(e => e.TargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("target_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Who)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("who");

                entity.Property(e => e.WorthIt).HasColumnName("worth_it");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GoalUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers95");
            });

            modelBuilder.Entity<GraduateConnection>(entity =>
            {
                entity.ToTable("graduate_connection");

                entity.Property(e => e.GraduateConnectionId).HasColumnName("graduate_connection_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Q10).HasColumnName("q10");

                entity.Property(e => e.Q11).HasColumnName("q11");

                entity.Property(e => e.Q11Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q11_comments");

                entity.Property(e => e.Q12).HasColumnName("q12");

                entity.Property(e => e.Q12Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q12_comments");

                entity.Property(e => e.Q13).HasColumnName("q13");

                entity.Property(e => e.Q14).HasColumnName("q14");

                entity.Property(e => e.Q15).HasColumnName("q15");

                entity.Property(e => e.Q16).HasColumnName("q16");

                entity.Property(e => e.Q16Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q16_comments");

                entity.Property(e => e.Q17).HasColumnName("q17");

                entity.Property(e => e.Q18).HasColumnName("q18");

                entity.Property(e => e.Q1a).HasColumnName("q1a");

                entity.Property(e => e.Q1b).HasColumnName("q1b");

                entity.Property(e => e.Q2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q2");

                entity.Property(e => e.Q3Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q3_comments");

                entity.Property(e => e.Q3a)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q3a");

                entity.Property(e => e.Q3b).HasColumnName("q3b");

                entity.Property(e => e.Q4)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("q4");

                entity.Property(e => e.Q5Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q5_comments");

                entity.Property(e => e.Q5a)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q5a");

                entity.Property(e => e.Q5b)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("q5b");

                entity.Property(e => e.Q6)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("q6");

                entity.Property(e => e.Q7)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("q7");

                entity.Property(e => e.Q8a).HasColumnName("q8a");

                entity.Property(e => e.Q8b).HasColumnName("q8b");

                entity.Property(e => e.Q8c).HasColumnName("q8c");

                entity.Property(e => e.Q8d).HasColumnName("q8d");

                entity.Property(e => e.Q8e).HasColumnName("q8e");

                entity.Property(e => e.Q8f).HasColumnName("q8f");

                entity.Property(e => e.Q8g).HasColumnName("q8g");

                entity.Property(e => e.Q9a).HasColumnName("q9a");

                entity.Property(e => e.Q9b).HasColumnName("q9b");

                entity.Property(e => e.Q9c).HasColumnName("q9c");

                entity.Property(e => e.Q9d).HasColumnName("q9d");

                entity.Property(e => e.Q9e).HasColumnName("q9e");

                entity.Property(e => e.Q9f).HasColumnName("q9f");

                entity.Property(e => e.Q9g).HasColumnName("q9g");
            });

            modelBuilder.Entity<HideActivityByParticipant>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.ActivityId });

                entity.ToTable("hide_activity_by_participant");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            });

            modelBuilder.Entity<HideActivityByProgram>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.ActivityId });

                entity.ToTable("hide_activity_by_program");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("holiday");

                entity.Property(e => e.HolidayId).HasColumnName("holiday_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.HolidayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("holiday_date");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<Hpa>(entity =>
            {
                entity.ToTable("hpa");

                entity.Property(e => e.HpaId).HasColumnName("hpa_id");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.ArchivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("archived_date");

                entity.Property(e => e.Hpa1)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("hpa");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<ImperativeImportant>(entity =>
            {
                entity.HasKey(e => e.ImperativeImportantId)
                    .HasName("PKii")
                    .IsClustered(false);

                entity.ToTable("imperative_important");

                entity.Property(e => e.ImperativeImportantId).HasColumnName("imperative_important_id");

                entity.Property(e => e.Completed)
                    .HasColumnType("datetime")
                    .HasColumnName("completed");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Imperative).HasColumnName("imperative");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Priority)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("priority");

                entity.Property(e => e.Task)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("task");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ImperativeImportants)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers86");
            });

            modelBuilder.Entity<IntroductionLink>(entity =>
            {
                entity.HasKey(e => e.IntroLinkId);

                entity.ToTable("introduction_links");

                entity.Property(e => e.IntroLinkId).HasColumnName("intro_link_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.IntroLinkRef)
                    .HasMaxLength(200)
                    .HasColumnName("intro_link_ref");

                entity.Property(e => e.IntroLinkTitle)
                    .HasMaxLength(200)
                    .HasColumnName("intro_link_title");

                entity.Property(e => e.OrderBy).HasColumnName("order_by");
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("invoice_payment");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Invoice).HasColumnName("invoice");

                entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");

                entity.Property(e => e.Paid)
                    .HasColumnType("datetime")
                    .HasColumnName("paid");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<Kpi>(entity =>
            {
                entity.HasKey(e => e.KpiId)
                    .HasName("PK81")
                    .IsClustered(false);

                entity.ToTable("kpi");

                entity.Property(e => e.KpiId).HasColumnName("kpi_id");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.ArchivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("archived_date");

                entity.Property(e => e.Definition)
                    .HasMaxLength(2000)
                    .HasColumnName("definition");

                entity.Property(e => e.Measurement)
                    .HasMaxLength(2000)
                    .HasColumnName("measurement");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nature)
                    .HasMaxLength(4000)
                    .HasColumnName("nature");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Performance)
                    .HasMaxLength(2000)
                    .HasColumnName("performance");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.Kpis)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipant109");
            });

            modelBuilder.Entity<Lead2004>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lead2004");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Ptype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ptype");
            });

            modelBuilder.Entity<Lead2005list>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lead2005list");

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Groups).HasColumnName("groups");

                entity.Property(e => e.Licensee)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("licensee");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<LeadCourse>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.Fullname, e.Email });

                entity.ToTable("lead_course");

                entity.HasIndex(e => e.Lcid, "lcid_lead_course")
                    .IsUnique();

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fullname")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lcid)
                    .HasColumnName("lcid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NominationType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nomination_type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LeadNomination>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lead_nomination");

                entity.Property(e => e.NominationType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nomination_type")
                    .HasDefaultValueSql("('E')")
                    .IsFixedLength(true);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");
            });

            modelBuilder.Entity<LeadNominationBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lead_nomination_backup");

                entity.Property(e => e.NominationType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nomination_type")
                    .HasDefaultValueSql("('E')")
                    .IsFixedLength(true);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");
            });

            modelBuilder.Entity<LearningseatRaw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("learningseat_raw");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Completion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("completion");

                entity.Property(e => e.Extra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra");

                entity.Property(e => e.LastUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_update");

                entity.Property(e => e.Learningcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("learningcode");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Start)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("start");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<LearningseatResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("learningseat_results");

                entity.Property(e => e.Companyid)
                    .HasMaxLength(20)
                    .HasColumnName("companyid");

                entity.Property(e => e.CompletionDate)
                    .HasMaxLength(20)
                    .HasColumnName("completion_date");

                entity.Property(e => e.Completionstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("completionstatus")
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastUpdated)
                    .HasMaxLength(20)
                    .HasColumnName("date_last_updated");

                entity.Property(e => e.Learningcode)
                    .HasMaxLength(20)
                    .HasColumnName("learningcode");

                entity.Property(e => e.LearningseatId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("learningseat_id");

                entity.Property(e => e.Score)
                    .HasMaxLength(20)
                    .HasColumnName("score");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(20)
                    .HasColumnName("start_date");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasKey(e => e.LessonId)
                    .HasName("pk2")
                    .IsClustered(false);

                entity.ToTable("lesson");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.AssignmentEmail)
                    .HasMaxLength(1000)
                    .HasColumnName("assignment_email");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CoursePart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_part");

                entity.Property(e => e.DaysSincePrevLesson)
                    .HasColumnName("days_since_prev_lesson")
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.Extras)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("extras");

                entity.Property(e => e.FacBill1).HasColumnName("fac_bill_1");

                entity.Property(e => e.FacBill2).HasColumnName("fac_bill_2");

                entity.Property(e => e.FirstLesson).HasColumnName("first_lesson");

                entity.Property(e => e.FmiElementId).HasColumnName("fmi_element_id");

                entity.Property(e => e.LastLesson).HasColumnName("last_lesson");

                entity.Property(e => e.LeadDiscussion).HasColumnName("lead_discussion");

                entity.Property(e => e.LearningOutcomeTitle)
                    .HasMaxLength(200)
                    .HasColumnName("learning_outcome_title");

                entity.Property(e => e.LessonDuration)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("lesson_duration")
                    .HasDefaultValueSql("((2.0))");

                entity.Property(e => e.LessonName)
                    .HasMaxLength(50)
                    .HasColumnName("lesson_name");

                entity.Property(e => e.LessonSeq).HasColumnName("lesson_seq");

                entity.Property(e => e.LessonTitle)
                    .HasMaxLength(100)
                    .HasColumnName("lesson_title");

                entity.Property(e => e.TeamView2).HasColumnName("TeamView_2");
            });

            modelBuilder.Entity<LessonEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lesson_email");

                entity.HasIndex(e => e.LessonEmailId, "PK46")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Attachment)
                    .HasMaxLength(100)
                    .HasColumnName("attachment");

                entity.Property(e => e.Body)
                    .HasMaxLength(4000)
                    .HasColumnName("body");

                entity.Property(e => e.CoursePart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_part");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Html)
                    .HasColumnName("html")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModified)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("last_modified");

                entity.Property(e => e.LessonEmailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("lesson_email_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.SenderFacilitator)
                    .HasColumnName("sender_facilitator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Subject)
                    .HasMaxLength(150)
                    .HasColumnName("subject");

                entity.Property(e => e.ToCoach)
                    .HasColumnName("to_coach")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToFacilitator)
                    .HasColumnName("to_facilitator")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToMm)
                    .HasColumnName("to_mm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToParticipant)
                    .HasColumnName("to_participant")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LessonGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lesson_group");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.GroupSeq).HasColumnName("group_seq");

                entity.Property(e => e.LessonGroupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("lesson_group_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.LessonSeq).HasColumnName("lesson_seq");
            });

            modelBuilder.Entity<LessonQuestion>(entity =>
            {
                entity.ToTable("lesson_questions");

                entity.HasIndex(e => e.LessonQuestionId, "PK15")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.LessonQuestionId).HasColumnName("lesson_question_id");

                entity.Property(e => e.Accomplishment).HasColumnName("accomplishment");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.CompetencyLog)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("competency_log");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.QuestionPost)
                    .HasMaxLength(400)
                    .HasColumnName("question_post");

                entity.Property(e => e.QuestionPre)
                    .HasMaxLength(400)
                    .HasColumnName("question_pre");

                entity.Property(e => e.ResponseLength).HasColumnName("response_length");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<Licensee>(entity =>
            {
                entity.HasKey(e => e.CatscanMasterLicenseeId)
                    .HasName("PK_course_schedule");

                entity.ToTable("licensees");

                entity.Property(e => e.CatscanMasterLicenseeId)
                    .ValueGeneratedNever()
                    .HasColumnName("catscan_master_licensee_id");

                entity.Property(e => e.Contact)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact_number");

                entity.Property(e => e.CourseScheduleLine1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("course_schedule_line_1");

                entity.Property(e => e.CourseScheduleLine2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("course_schedule_line_2");

                entity.Property(e => e.CourseScheduleLine3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("course_schedule_line_3");

                entity.Property(e => e.CourseScheduleLine4)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("course_schedule_line_4");
            });

            modelBuilder.Entity<LicenseeAccess>(entity =>
            {
                entity.HasKey(e => new { e.LicenseeId, e.AccessLicenseeId })
                    .HasName("PK61")
                    .IsClustered(false);

                entity.ToTable("licensee_access");

                entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");

                entity.Property(e => e.AccessLicenseeId).HasColumnName("access_licensee_id");

                entity.HasOne(d => d.AccessLicensee)
                    .WithMany(p => p.LicenseeAccessAccessLicensees)
                    .HasForeignKey(d => d.AccessLicenseeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__licensee___acces__1F2E9E6D");

                entity.HasOne(d => d.Licensee)
                    .WithMany(p => p.LicenseeAccessLicensees)
                    .HasForeignKey(d => d.LicenseeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__licensee___licen__2022C2A6");
            });

            modelBuilder.Entity<LicenseeChange>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.PreviousLicenseeId });

                entity.ToTable("licensee_changes");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PreviousLicenseeId).HasColumnName("previous_licensee_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LicenseeOld>(entity =>
            {
                entity.HasKey(e => e.LicenseeId)
                    .HasName("PK_licensee_1");

                entity.ToTable("licensee_old");

                entity.HasIndex(e => e.LicenseeId, "pk_licensee")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .HasColumnName("company");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Logon)
                    .HasMaxLength(50)
                    .HasColumnName("logon");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<LiteracyNumeracy>(entity =>
            {
                entity.HasKey(e => e.ParticipantId);

                entity.ToTable("literacy_numeracy");

                entity.Property(e => e.ParticipantId)
                    .ValueGeneratedNever()
                    .HasColumnName("participant_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Employer)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("employer");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.LlnId).HasColumnName("LLN_id");

                entity.Property(e => e.Question1).HasColumnName("question1");

                entity.Property(e => e.Question10).HasColumnName("question10");

                entity.Property(e => e.Question11).HasColumnName("question11");

                entity.Property(e => e.Question12).HasColumnName("question12");

                entity.Property(e => e.Question13).HasColumnName("question13");

                entity.Property(e => e.Question14).HasColumnName("question14");

                entity.Property(e => e.Question15).HasColumnName("question15");

                entity.Property(e => e.Question16).HasColumnName("question16");

                entity.Property(e => e.Question17).HasColumnName("question17");

                entity.Property(e => e.Question18).HasColumnName("question18");

                entity.Property(e => e.Question19).HasColumnName("question19");

                entity.Property(e => e.Question2).HasColumnName("question2");

                entity.Property(e => e.Question3).HasColumnName("question3");

                entity.Property(e => e.Question4).HasColumnName("question4");

                entity.Property(e => e.Question5).HasColumnName("question5");

                entity.Property(e => e.Question6).HasColumnName("question6");

                entity.Property(e => e.Question7).HasColumnName("question7");

                entity.Property(e => e.Question8).HasColumnName("question8");

                entity.Property(e => e.Question9).HasColumnName("question9");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.XmlData)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lln>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LLN");

                entity.Property(e => e.Answers)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("answers");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LlnId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LLN_id");

                entity.Property(e => e.MaxScore).HasColumnName("max_score");

                entity.Property(e => e.PassScore).HasColumnName("pass_score");

                entity.Property(e => e.VersionNo).HasColumnName("version_no");

                entity.Property(e => e.XslTemplate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Xsl_template");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("location");

                entity.HasIndex(e => e.StateCode, "IDX_state_code");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .HasColumnName("address");

                entity.Property(e => e.Archived)
                    .HasColumnType("datetime")
                    .HasColumnName("archived");

                entity.Property(e => e.BuildingName)
                    .HasMaxLength(250)
                    .HasColumnName("building_name");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("location_id");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("location_name");

                entity.Property(e => e.MapName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("map_name");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .HasColumnName("post_code");

                entity.Property(e => e.PpbId).HasColumnName("ppb_id");

                entity.Property(e => e.Regional).HasColumnName("regional");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("state_code");

                entity.Property(e => e.StreetName)
                    .HasMaxLength(250)
                    .HasColumnName("street_name");

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(250)
                    .HasColumnName("street_number");

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .HasColumnName("suburb");

                entity.Property(e => e.UnitDetails)
                    .HasMaxLength(250)
                    .HasColumnName("unit_details");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.VenueCode)
                    .HasMaxLength(20)
                    .HasColumnName("venue_code");

                entity.Property(e => e.VettrakId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vettrak_id");
            });

            modelBuilder.Entity<MailingListImport>(entity =>
            {
                entity.ToTable("mailing_list_import");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CourseManager).HasMaxLength(255);

                entity.Property(e => e.CourseParticipant).HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Imported)
                    .HasColumnType("datetime")
                    .HasColumnName("imported");

                entity.Property(e => e.ImportedFrom).HasMaxLength(255);

                entity.Property(e => e.InterestedIn).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OrganisationName).HasMaxLength(255);

                entity.Property(e => e.OriginalDate).HasColumnType("datetime");

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.PreviousDealings).HasMaxLength(255);

                entity.Property(e => e.PrimaryPhone).HasMaxLength(255);

                entity.Property(e => e.SecondaryEmailAddress).HasMaxLength(255);

                entity.Property(e => e.SecondaryPhone).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<MajorClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("major_clients");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("client_name");

                entity.Property(e => e.MajorClientId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("major_client_id");

                entity.Property(e => e.Url)
                    .HasMaxLength(120)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<MajorClientCourseId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("major_client_course_ids");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.MajorClientCourseId1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("major_client_course_id");

                entity.Property(e => e.MajorClientId).HasColumnName("major_client_id");
            });

            modelBuilder.Entity<MasterDreamList>(entity =>
            {
                entity.HasKey(e => e.MasterDreamListId)
                    .HasName("pk_master_dream_list")
                    .IsClustered(false);

                entity.ToTable("master_dream_list");

                entity.Property(e => e.MasterDreamListId).HasColumnName("master_dream_list_id");

                entity.Property(e => e.Achieved)
                    .HasColumnType("datetime")
                    .HasColumnName("achieved");

                entity.Property(e => e.AreaOfLife)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("area_of_life");

                entity.Property(e => e.DreamDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dream_date");

                entity.Property(e => e.Item)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.MasterDreamLists)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipant31");
            });

            modelBuilder.Entity<McrPcr>(entity =>
            {
                entity.ToTable("mcr_pcr");

                entity.Property(e => e.McrPcrId).HasColumnName("mcr_pcr_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mcr).HasColumnName("mcr");

                entity.Property(e => e.MmId).HasColumnName("mm_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Pcr).HasColumnName("pcr");

                entity.Property(e => e._1a).HasColumnName("1a");

                entity.Property(e => e._1b).HasColumnName("1b");

                entity.Property(e => e._1c).HasColumnName("1c");

                entity.Property(e => e._1d).HasColumnName("1d");

                entity.Property(e => e._2a).HasColumnName("2a");

                entity.Property(e => e._2b).HasColumnName("2b");

                entity.Property(e => e._2c).HasColumnName("2c");

                entity.Property(e => e._2d).HasColumnName("2d");

                entity.Property(e => e._2e).HasColumnName("2e");

                entity.Property(e => e._2f).HasColumnName("2f");

                entity.Property(e => e._3a).HasColumnName("3a");

                entity.Property(e => e._3b).HasColumnName("3b");

                entity.Property(e => e._3c).HasColumnName("3c");

                entity.Property(e => e._3d).HasColumnName("3d");

                entity.Property(e => e._4a).HasColumnName("4a");

                entity.Property(e => e._4b).HasColumnName("4b");

                entity.Property(e => e._5).HasColumnName("5");

                entity.Property(e => e._6).HasColumnName("6");

                entity.Property(e => e._7a)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("7a");

                entity.Property(e => e._7b)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("7b");

                entity.Property(e => e._7c)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("7c");

                entity.Property(e => e._7d).HasColumnName("7d");

                entity.Property(e => e._8)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("8");
            });

            modelBuilder.Entity<McrPcrResult>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.ToTable("mcr_pcr_results");

                entity.Property(e => e.ResultId).HasColumnName("result_id");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.CourseIdVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_id_version");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MmId).HasColumnName("mm_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.R1)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r1");

                entity.Property(e => e.R10)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r10");

                entity.Property(e => e.R11)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r11");

                entity.Property(e => e.R12)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r12");

                entity.Property(e => e.R13)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r13");

                entity.Property(e => e.R14)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r14");

                entity.Property(e => e.R15)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r15");

                entity.Property(e => e.R16)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r16");

                entity.Property(e => e.R17)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r17");

                entity.Property(e => e.R18)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r18");

                entity.Property(e => e.R19)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r19");

                entity.Property(e => e.R2)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r2");

                entity.Property(e => e.R20)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r20");

                entity.Property(e => e.R21)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r21");

                entity.Property(e => e.R22)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r22");

                entity.Property(e => e.R23)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r23");

                entity.Property(e => e.R24)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r24");

                entity.Property(e => e.R25)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r25");

                entity.Property(e => e.R26)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r26");

                entity.Property(e => e.R27)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r27");

                entity.Property(e => e.R28)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r28");

                entity.Property(e => e.R29)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r29");

                entity.Property(e => e.R3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r3");

                entity.Property(e => e.R30)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r30");

                entity.Property(e => e.R31)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r31");

                entity.Property(e => e.R32)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r32");

                entity.Property(e => e.R33)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r33");

                entity.Property(e => e.R34)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r34");

                entity.Property(e => e.R35)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r35");

                entity.Property(e => e.R36)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r36");

                entity.Property(e => e.R37)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r37");

                entity.Property(e => e.R38)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r38");

                entity.Property(e => e.R39)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r39");

                entity.Property(e => e.R4)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r4");

                entity.Property(e => e.R40)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r40");

                entity.Property(e => e.R41)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r41");

                entity.Property(e => e.R42)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r42");

                entity.Property(e => e.R43)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r43");

                entity.Property(e => e.R44)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r44");

                entity.Property(e => e.R45)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r45");

                entity.Property(e => e.R46)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r46");

                entity.Property(e => e.R47)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r47");

                entity.Property(e => e.R48)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r48");

                entity.Property(e => e.R49)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r49");

                entity.Property(e => e.R5)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r5");

                entity.Property(e => e.R50)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r50");

                entity.Property(e => e.R51)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r51");

                entity.Property(e => e.R52)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r52");

                entity.Property(e => e.R53)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r53");

                entity.Property(e => e.R54)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r54");

                entity.Property(e => e.R55)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r55");

                entity.Property(e => e.R6)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r6");

                entity.Property(e => e.R7)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r7");

                entity.Property(e => e.R8)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r8");

                entity.Property(e => e.R9)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("r9");
            });

            modelBuilder.Entity<Nat120Log>(entity =>
            {
                entity.ToTable("nat120_log");

                entity.Property(e => e.Nat120LogId).HasColumnName("nat120_log_id");

                entity.Property(e => e.ClientFeesOther)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("client_fees_other")
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("client_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("client_tuition_fee")
                    .IsFixedLength(true);

                entity.Property(e => e.CommencingCourseIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("commencing_course_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.CompetencyEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_end_date");

                entity.Property(e => e.CompetencyStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_start_date");

                entity.Property(e => e.CourseCommencementDate)
                    .HasColumnType("datetime")
                    .HasColumnName("course_commencement_date");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.DeliveryModeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("delivery_mode_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.DeliveryProviderAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("delivery_provider_abn")
                    .IsFixedLength(true);

                entity.Property(e => e.EligibilityExemptionIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("eligibility_exemption_indicator")
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("enrolment_date");

                entity.Property(e => e.EnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.FeeExemption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fee_exemption")
                    .IsFixedLength(true);

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FundingSource)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("funding_source")
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("funding_source_national")
                    .IsFixedLength(true);

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.HoursAttended)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("hours_attended")
                    .IsFixedLength(true);

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("industry_code")
                    .IsFixedLength(true);

                entity.Property(e => e.LocationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("location_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.Nat120Id).HasColumnName("nat120_id");

                entity.Property(e => e.OutcomeIdentifierNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("outcome_identifier_national")
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierOrganisation)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("outcome_identifier_organisation")
                    .IsFixedLength(true);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PurchasingContractIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("purchasing_contract_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractSchedule)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("purchasing_contract_schedule")
                    .IsFixedLength(true);

                entity.Property(e => e.QualCourseIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("qual_course_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.ScheduledHours)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("scheduled_hours")
                    .IsFixedLength(true);

                entity.Property(e => e.StudentIdentifier).HasColumnName("student_identifier");

                entity.Property(e => e.StudyReasonIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("study_reason_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingContractIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("training_contract_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCompetencyIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("unit_competency_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.VetFeeHelp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("vet_fee_help")
                    .IsFixedLength(true);

                entity.Property(e => e.VetFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("vet_flag")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Nat120vic>(entity =>
            {
                entity.ToTable("nat120vic");

                entity.Property(e => e.Nat120vicId).HasColumnName("nat120vic_id");

                entity.Property(e => e.AssociatedCourseIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientFeesOther)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("client_fees_other")
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CommencingCourseIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CompetencyEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_end_date");

                entity.Property(e => e.CompetencyStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_start_date");

                entity.Property(e => e.CourseCommencementDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.DeliveryModeIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DeliveryProviderAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("delivery_provider_abn")
                    .IsFixedLength(true);

                entity.Property(e => e.EligibilityExemptionIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityEndDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityStartDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_date")
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.FeeExemptionConcessionTypeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FundingEligibilityKey)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("funding_eligibility_key")
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceStateTrainingAuthority)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HoursAttended)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierTrainingOrganisation)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PredominantDeliveryMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProgramEnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractScheduleIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.QualificationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ScheduledHours)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SchoolTypeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SpecificFundingIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StudyReasonIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingContractIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationDeliveryLocationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCompetencyIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VetinSchoolsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETinSchoolsFlag")
                    .IsFixedLength(true);

                entity.Property(e => e.VetincomeContingentLoanIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETIncomeContingentLoanIndicator")
                    .IsFixedLength(true);

                entity.Property(e => e.WorkplaceAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("WorkplaceABN")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Nat120vicLma>(entity =>
            {
                entity.ToTable("nat120vic_lma");

                entity.Property(e => e.Nat120vicLmaId).HasColumnName("nat120vic_lma_id");

                entity.Property(e => e.AssociatedCourseIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientFeesOther)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("client_fees_other")
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CommencingCourseIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CompetencyEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_end_date");

                entity.Property(e => e.CompetencyStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_start_date");

                entity.Property(e => e.CourseCommencementDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryModeIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DeliveryProviderAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("delivery_provider_abn")
                    .IsFixedLength(true);

                entity.Property(e => e.EligibilityExemptionIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityEndDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityStartDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_date")
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.FeeExemptionConcessionTypeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FundingEligibilityKey)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("funding_eligibility_key")
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceStateTrainingAuthority)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HoursAttended)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierTrainingOrganisation)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PredominantDeliveryMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProgramEnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractScheduleIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.QualificationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ScheduledHours)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SchoolTypeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SpecificFundingIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StudyReasonIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingContractIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationDeliveryLocationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCompetencyIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VetinSchoolsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETinSchoolsFlag")
                    .IsFixedLength(true);

                entity.Property(e => e.VetincomeContingentLoanIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETIncomeContingentLoanIndicator")
                    .IsFixedLength(true);

                entity.Property(e => e.WorkplaceAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("WorkplaceABN")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Nat120vicLma7>(entity =>
            {
                entity.HasKey(e => e.Nat120vicLmaId)
                    .HasName("PK_nat120vic_lma");

                entity.ToTable("nat120vic_lma_7");

                entity.Property(e => e.Nat120vicLmaId).HasColumnName("nat120vic_lma_id");

                entity.Property(e => e.AssociatedCourseIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientFeesOther)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("client_fees_other")
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CommencingCourseIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CompetencyEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_end_date");

                entity.Property(e => e.CompetencyStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_start_date");

                entity.Property(e => e.CourseCommencementDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.DeliveryModeIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DeliveryProviderAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("delivery_provider_abn")
                    .IsFixedLength(true);

                entity.Property(e => e.EligibilityExemptionIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityEndDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityStartDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_date")
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.FeeExemptionConcessionTypeIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FundingEligibilityKey)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("funding_eligibility_key")
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceStateTrainingAuthority)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HoursAttended)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierTrainingOrganisation)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PredominantDeliveryMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProgramEnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractScheduleIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.QualificationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ScheduledHours)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SchoolTypeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SpecificFundingIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StudyReasonIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingContractIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationDeliveryLocationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCompetencyIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VetinSchoolsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETinSchoolsFlag")
                    .IsFixedLength(true);

                entity.Property(e => e.VetincomeContingentLoanIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETIncomeContingentLoanIndicator")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Nat120vicTp>(entity =>
            {
                entity.ToTable("nat120vic_tp");

                entity.Property(e => e.Nat120vicTpId).HasColumnName("nat120vic_tp_id");

                entity.Property(e => e.AssociatedCourseIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientFeesOther)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("client_fees_other")
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CommencingCourseIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CompetencyEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_end_date");

                entity.Property(e => e.CompetencyStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_start_date");

                entity.Property(e => e.CourseCommencementDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.DeliveryModeIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DeliveryProviderAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("delivery_provider_abn")
                    .IsFixedLength(true);

                entity.Property(e => e.EligibilityExemptionIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityEndDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityStartDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_date")
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.FeeExemptionConcessionTypeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FundingEligibilityKey)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("funding_eligibility_key")
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceStateTrainingAuthority)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HoursAttended)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierTrainingOrganisation)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PredominantDeliveryMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProgramEnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractScheduleIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.QualificationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ScheduledHours)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SchoolTypeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SpecificFundingIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StudyReasonIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingContractIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationDeliveryLocationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCompetencyIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VetinSchoolsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETinSchoolsFlag")
                    .IsFixedLength(true);

                entity.Property(e => e.VetincomeContingentLoanIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETIncomeContingentLoanIndicator")
                    .IsFixedLength(true);

                entity.Property(e => e.WorkplaceAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("WorkplaceABN")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Nat120vicTp7>(entity =>
            {
                entity.HasKey(e => e.Nat120vicTpId)
                    .HasName("PK_nat120vic_tp");

                entity.ToTable("nat120vic_tp_7");

                entity.Property(e => e.Nat120vicTpId).HasColumnName("nat120vic_tp_id");

                entity.Property(e => e.AssociatedCourseIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientFeesOther)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("client_fees_other")
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CommencingCourseIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CompetencyEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_end_date");

                entity.Property(e => e.CompetencyStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("competency_start_date");

                entity.Property(e => e.CourseCommencementDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliveryModeIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DeliveryProviderAbn)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("delivery_provider_abn")
                    .IsFixedLength(true);

                entity.Property(e => e.EligibilityExemptionIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityEndDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentActivityStartDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_date")
                    .IsFixedLength(true);

                entity.Property(e => e.EnrolmentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_identifier")
                    .IsFixedLength(true);

                entity.Property(e => e.FeeExemptionConcessionTypeIdentifier)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FundingEligibilityKey)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("funding_eligibility_key")
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FundingSourceStateTrainingAuthority)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HoursAttended)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IndustryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierNational)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutcomeIdentifierTrainingOrganisation)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PurchasingContractScheduleIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.QualificationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ScheduledHours)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SpecificFundingIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StudyReasonIdentifier)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingContractIdentifierAustralianApprenticeships)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingOrganisationDeliveryLocationIdentifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UnitCompetencyIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VetinSchoolsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETinSchoolsFlag")
                    .IsFixedLength(true);

                entity.Property(e => e.VetincomeContingentLoanIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VETIncomeContingentLoanIndicator")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<NominalDuration>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.StateCode, e.DurationMonths, e.StartDate });

                entity.ToTable("nominal_duration");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("state_code");

                entity.Property(e => e.DurationMonths).HasColumnName("duration_months");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<NswFundedParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NSW_funded_participants");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<NswFundedParticipants2015>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NSW_funded_participants_2015");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<OnlineCourse>(entity =>
            {
                entity.HasKey(e => e.OnlineCourseId)
                    .HasName("pk94")
                    .IsClustered(false);

                entity.ToTable("online_course");

                entity.Property(e => e.OnlineCourseId).HasColumnName("online_course_id");

                entity.Property(e => e.OnlineCourseTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("online_course_title");
            });

            modelBuilder.Entity<OnlineModule>(entity =>
            {
                entity.HasKey(e => e.OnlineModuleId)
                    .HasName("PK85")
                    .IsClustered(false);

                entity.ToTable("online_module");

                entity.HasIndex(e => new { e.CourseId, e.Module }, "ak_online_module")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.OnlineModuleId).HasColumnName("online_module_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .HasColumnName("duration");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("module");

                entity.Property(e => e.ModuleTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("module_title");

                entity.Property(e => e.OnlineCourseId).HasColumnName("online_course_id");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.OnlineModules)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refcourse121");

                entity.HasOne(d => d.FmiUnit)
                    .WithMany(p => p.OnlineModules)
                    .HasForeignKey(d => d.FmiUnitId)
                    .HasConstraintName("Reffmi_unit122");

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.OnlineModules)
                    .HasForeignKey(d => d.LessonId)
                    .HasConstraintName("Reflesson139");

                entity.HasOne(d => d.OnlineCourse)
                    .WithMany(p => p.OnlineModules)
                    .HasForeignKey(d => d.OnlineCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refonline_course138");
            });

            modelBuilder.Entity<PartCompTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("part_comp_temp");

                entity.Property(e => e.ClientTuitionFee)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("client_tuition_fee");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");
            });

            modelBuilder.Entity<PartCourse>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.CoursePart });

                entity.ToTable("part_courses");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CoursePart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_part");

                entity.Property(e => e.AntaCourseCode)
                    .HasMaxLength(100)
                    .HasColumnName("anta_course_code");
            });

            modelBuilder.Entity<PartId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("partIds");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertSourceInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("insert_source_ind");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.WhenInserted)
                    .HasColumnType("datetime")
                    .HasColumnName("when_inserted")
                    .HasComputedColumnSql("(getdate())", false);
            });

            modelBuilder.Entity<PartIdsExcluded>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("partIds_Excluded");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertSourceInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("insert_source_ind");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.WhenInserted)
                    .HasColumnType("datetime")
                    .HasColumnName("when_inserted")
                    .HasComputedColumnSql("(getdate())", false);
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.ToTable("participant");

                entity.HasIndex(e => e.Discontinued, "IDX_discontinued");

                entity.HasIndex(e => e.ProgramId, "IDX_program_id");

                entity.HasIndex(e => e.ParticipantId, "PK31")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.ProgramId, e.UserId }, "ak31");

                entity.HasIndex(e => e.UserId, "participant_1")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.AgreedRate)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("agreed_rate");

                entity.Property(e => e.AssessNotAgreed).HasColumnName("assess_not_agreed");

                entity.Property(e => e.CertificateIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_issued");

                entity.Property(e => e.CertificatePending)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_pending");

                entity.Property(e => e.CertificationReason)
                    .HasMaxLength(20)
                    .HasColumnName("certification_reason");

                entity.Property(e => e.Confirmed1)
                    .HasColumnType("datetime")
                    .HasColumnName("confirmed_1");

                entity.Property(e => e.Confirmed2)
                    .HasColumnType("datetime")
                    .HasColumnName("confirmed_2");

                entity.Property(e => e.ContactDetailsConfirmed)
                    .HasColumnName("contact_details_confirmed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CourseExpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("course_expiry");

                entity.Property(e => e.Discontinued)
                    .HasColumnName("discontinued")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscontinuedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("discontinued_date");

                entity.Property(e => e.EnrolmentType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_type")
                    .IsFixedLength(true);

                entity.Property(e => e.ExpectedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expected_date");

                entity.Property(e => e.ExpiredQualAgreed).HasColumnName("expired_qual_agreed");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry_date")
                    .HasComment("PDP expiry date");

                entity.Property(e => e.ExtendAccess)
                    .HasColumnType("datetime")
                    .HasColumnName("extend_access");

                entity.Property(e => e.Flm5Enabled)
                    .HasColumnName("flm5_enabled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FundingHold)
                    .HasColumnType("datetime")
                    .HasColumnName("funding_hold");

                entity.Property(e => e.FundingInformationHtml)
                    .IsUnicode(false)
                    .HasColumnName("funding_information_html");

                entity.Property(e => e.Graduated).HasColumnName("graduated");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MeetingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("meeting_date");

                entity.Property(e => e.NoQualification)
                    .HasColumnName("no_qualification")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasColumnName("notes");

                entity.Property(e => e.OldParticipantId).HasColumnName("old_participant_id");

                entity.Property(e => e.Paid)
                    .HasColumnType("datetime")
                    .HasColumnName("paid");

                entity.Property(e => e.Paper).HasColumnName("paper");

                entity.Property(e => e.Passport)
                    .HasColumnName("passport")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PaymentCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("payment_completed");

                entity.Property(e => e.PdpImport)
                    .HasColumnName("pdp_import")
                    .HasComment("This field is used to check whether goals have been carried over from normal courses to PDP course");

                entity.Property(e => e.PeerReviewedActivityIds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("peer_reviewed_activity_ids");

                entity.Property(e => e.PotwAttempted)
                    .HasColumnType("datetime")
                    .HasColumnName("potw_attempted");

                entity.Property(e => e.PotwPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("potw_password");

                entity.Property(e => e.PotwUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("potw_user");

                entity.Property(e => e.PreCourseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pre_course_date");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.ReceivedCourseMaterial).HasColumnName("received_course_material");

                entity.Property(e => e.RelatedParticipantId).HasColumnName("related_participant_id");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("review_date");

                entity.Property(e => e.ReviewMcr).HasColumnName("review_mcr");

                entity.Property(e => e.ReviewPcr).HasColumnName("review_pcr");

                entity.Property(e => e.ReviewedCourseBrochure).HasColumnName("reviewed_course_brochure");

                entity.Property(e => e.ReviewedFundingInformation).HasColumnName("reviewed_funding_information");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date")
                    .HasComment("PDP start date");

                entity.Property(e => e.StatusNow)
                    .HasColumnName("status_now")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TeamViewClose1)
                    .HasColumnType("datetime")
                    .HasColumnName("TeamView_close_1");

                entity.Property(e => e.TeamViewClose2)
                    .HasColumnType("datetime")
                    .HasColumnName("TeamView_close_2");

                entity.Property(e => e.TeamViewCreated1).HasColumnName("TeamView_created_1");

                entity.Property(e => e.TeamViewCreated2).HasColumnName("TeamView_created_2");

                entity.Property(e => e.UnderstandAmNonAccredited).HasColumnName("understand_am_nonAccredited");

                entity.Property(e => e.UnderstandNoSoa).HasColumnName("understand_no_SOA");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ViewedCodeOfPractice).HasColumnName("viewed_code_of_practice");

                entity.Property(e => e.WelcomeEmailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("welcome_email_date");
            });

            modelBuilder.Entity<ParticipantAccess>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.UserId, e.Access })
                    .HasName("PK59")
                    .IsClustered(false);

                entity.ToTable("participant_access");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Access)
                    .HasColumnType("datetime")
                    .HasColumnName("access")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ParticipantAccesses)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipant79");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ParticipantAccesses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers80");
            });

            modelBuilder.Entity<ParticipantCompetency>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.FmiUnitId, e.QualificationId });

                entity.ToTable("participant_competency");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.AchievedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("achieved_by");

                entity.Property(e => e.Archived)
                    .HasColumnType("datetime")
                    .HasColumnName("archived");

                entity.Property(e => e.AttendedHours).HasColumnName("attended_hours");

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("client_tuition_fee");

                entity.Property(e => e.CpsNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cps_number");

                entity.Property(e => e.CtRplDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ct_rpl_date");

                entity.Property(e => e.CtRplStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ct_rpl_status");

                entity.Property(e => e.CurrentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_end_date");

                entity.Property(e => e.CurrentStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_start_date");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("date_achieved");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndDateExtended)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date_extended");

                entity.Property(e => e.EvidenceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("evidence_date");

                entity.Property(e => e.FundingReported)
                    .HasColumnType("datetime")
                    .HasColumnName("funding_reported");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MmSignoffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_signoff_date");

                entity.Property(e => e.MmSignoffUserId).HasColumnName("mm_signoff_user_id");

                entity.Property(e => e.OverdueUpdate).HasColumnName("overdue_update");

                entity.Property(e => e.PartCompId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("part_comp_id");

                entity.Property(e => e.PreviousAttendedHours).HasColumnName("previous_attended_hours");

                entity.Property(e => e.PreviousEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_end_date");

                entity.Property(e => e.PreviousStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_start_date");

                entity.Property(e => e.ProposedEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("proposed_end_date");

                entity.Property(e => e.PurchasingContractIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("purchasing_contract_identifier");

                entity.Property(e => e.ReportedId).HasColumnName("reported_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.TdwUpdate).HasColumnName("TDW_update");

                entity.Property(e => e.TpComments)
                    .HasMaxLength(4000)
                    .HasColumnName("tp_comments");
            });

            modelBuilder.Entity<ParticipantCompetencyFf>(entity =>
            {
                entity.ToTable("participant_competency_ffs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");
            });

            modelBuilder.Entity<ParticipantCompetencyFfsQldBackup>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.FmiUnitId, e.QualificationId });

                entity.ToTable("participant_competency_ffs_qld_backup");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.AchievedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("achieved_by");

                entity.Property(e => e.Archived)
                    .HasColumnType("datetime")
                    .HasColumnName("archived");

                entity.Property(e => e.AttendedHours).HasColumnName("attended_hours");

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("client_tuition_fee");

                entity.Property(e => e.CpsNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cps_number");

                entity.Property(e => e.CtRplDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ct_rpl_date");

                entity.Property(e => e.CtRplStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ct_rpl_status");

                entity.Property(e => e.CurrentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_end_date");

                entity.Property(e => e.CurrentStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_start_date");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("date_achieved");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndDateExtended)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date_extended");

                entity.Property(e => e.EvidenceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("evidence_date");

                entity.Property(e => e.FundingReported)
                    .HasColumnType("datetime")
                    .HasColumnName("funding_reported");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.OverdueUpdate).HasColumnName("overdue_update");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.PreviousAttendedHours).HasColumnName("previous_attended_hours");

                entity.Property(e => e.PreviousEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_end_date");

                entity.Property(e => e.PreviousStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_start_date");

                entity.Property(e => e.ProposedEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("proposed_end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.TdwUpdate).HasColumnName("TDW_update");

                entity.Property(e => e.TpComments)
                    .HasMaxLength(4000)
                    .HasColumnName("tp_comments");
            });

            modelBuilder.Entity<ParticipantCompetencyTemp>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.FmiUnitId, e.QualificationId });

                entity.ToTable("participant_competency_temp");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.AchievedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("achieved_by");

                entity.Property(e => e.Archived)
                    .HasColumnType("datetime")
                    .HasColumnName("archived");

                entity.Property(e => e.AttendedHours).HasColumnName("attended_hours");

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("client_tuition_fee");

                entity.Property(e => e.CpsNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cps_number");

                entity.Property(e => e.CtRplDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ct_rpl_date");

                entity.Property(e => e.CtRplStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ct_rpl_status");

                entity.Property(e => e.CurrentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_end_date");

                entity.Property(e => e.CurrentStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_start_date");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("date_achieved");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndDateExtended)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date_extended");

                entity.Property(e => e.EvidenceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("evidence_date");

                entity.Property(e => e.FundingReported)
                    .HasColumnType("datetime")
                    .HasColumnName("funding_reported");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MmSignoffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_signoff_date");

                entity.Property(e => e.MmSignoffUserId).HasColumnName("mm_signoff_user_id");

                entity.Property(e => e.OverdueUpdate).HasColumnName("overdue_update");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.PreviousAttendedHours).HasColumnName("previous_attended_hours");

                entity.Property(e => e.PreviousEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_end_date");

                entity.Property(e => e.PreviousStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_start_date");

                entity.Property(e => e.ProposedEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("proposed_end_date");

                entity.Property(e => e.PurchasingContractIdentifier)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("purchasing_contract_identifier");

                entity.Property(e => e.ReportedId).HasColumnName("reported_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.TdwUpdate).HasColumnName("TDW_update");

                entity.Property(e => e.TpComments)
                    .HasMaxLength(4000)
                    .HasColumnName("tp_comments");
            });

            modelBuilder.Entity<ParticipantCompetencyTemp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("participant_competency_temp2");

                entity.Property(e => e.CurrentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_end_date");

                entity.Property(e => e.CurrentStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_start_date");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndDateExtended)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date_extended");

                entity.Property(e => e.EvidenceDate).HasColumnName("evidence_date");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.PreviousEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_end_date");

                entity.Property(e => e.PreviousStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_start_date");

                entity.Property(e => e.ProposedEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("proposed_end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<ParticipantCompetencyTemp3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("participant_competency_temp3");

                entity.Property(e => e.BackupNumber).HasColumnName("backup_number");

                entity.Property(e => e.CurrentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_end_date");

                entity.Property(e => e.CurrentStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_start_date");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndDateExtended)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date_extended");

                entity.Property(e => e.EvidenceDate).HasColumnName("evidence_date");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.PreviousEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_end_date");

                entity.Property(e => e.PreviousStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_start_date");

                entity.Property(e => e.ProposedEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("proposed_end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<ParticipantCompetencyToReport>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.FmiUnitId, e.QualificationId });

                entity.ToTable("participant_competency_to_report");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.AchievedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("achieved_by");

                entity.Property(e => e.Archived)
                    .HasColumnType("datetime")
                    .HasColumnName("archived");

                entity.Property(e => e.AttendedHours).HasColumnName("attended_hours");

                entity.Property(e => e.ClientTuitionFee)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("client_tuition_fee");

                entity.Property(e => e.CtRplDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ct_rpl_date");

                entity.Property(e => e.CtRplStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ct_rpl_status");

                entity.Property(e => e.CurrentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_end_date");

                entity.Property(e => e.CurrentStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_start_date");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("date_achieved");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndDateExtended)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date_extended");

                entity.Property(e => e.EvidenceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("evidence_date");

                entity.Property(e => e.FundingReported)
                    .HasColumnType("datetime")
                    .HasColumnName("funding_reported");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OverdueUpdate).HasColumnName("overdue_update");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.PreviousAttendedHours).HasColumnName("previous_attended_hours");

                entity.Property(e => e.PreviousEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_end_date");

                entity.Property(e => e.PreviousStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_start_date");

                entity.Property(e => e.ProposedEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("proposed_end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.TdwUpdate).HasColumnName("TDW_update");

                entity.Property(e => e.TpComments)
                    .HasMaxLength(4000)
                    .HasColumnName("tp_comments");
            });

            modelBuilder.Entity<ParticipantPdpBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("participant_pdp_backup");

                entity.Property(e => e.AgreedRate)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("agreed_rate");

                entity.Property(e => e.CertificateIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_issued");

                entity.Property(e => e.CertificationReason)
                    .HasMaxLength(20)
                    .HasColumnName("certification_reason");

                entity.Property(e => e.ContactDetailsConfirmed).HasColumnName("contact_details_confirmed");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.DiscontinuedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("discontinued_date");

                entity.Property(e => e.EnrolmentType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("enrolment_type")
                    .IsFixedLength(true);

                entity.Property(e => e.ExpectedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expected_date");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.Flm5Enabled).HasColumnName("flm5_enabled");

                entity.Property(e => e.FundingHold).HasColumnName("funding_hold");

                entity.Property(e => e.Graduated).HasColumnName("graduated");

                entity.Property(e => e.MeetingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("meeting_date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasColumnName("notes");

                entity.Property(e => e.Paid)
                    .HasColumnType("datetime")
                    .HasColumnName("paid");

                entity.Property(e => e.Paper).HasColumnName("paper");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Passport).HasColumnName("passport");

                entity.Property(e => e.PdpImport).HasColumnName("pdp_import");

                entity.Property(e => e.PotwAttempted)
                    .HasColumnType("datetime")
                    .HasColumnName("potw_attempted");

                entity.Property(e => e.PotwPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("potw_password");

                entity.Property(e => e.PotwUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("potw_user");

                entity.Property(e => e.PreCourseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pre_course_date");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.RelatedParticipantId).HasColumnName("related_participant_id");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("review_date");

                entity.Property(e => e.ReviewMcr).HasColumnName("review_mcr");

                entity.Property(e => e.ReviewPcr).HasColumnName("review_pcr");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.TeamViewClose1)
                    .HasColumnType("datetime")
                    .HasColumnName("TeamView_close_1");

                entity.Property(e => e.TeamViewClose2)
                    .HasColumnType("datetime")
                    .HasColumnName("TeamView_close_2");

                entity.Property(e => e.TeamViewCreated1).HasColumnName("TeamView_created_1");

                entity.Property(e => e.TeamViewCreated2).HasColumnName("TeamView_created_2");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WelcomeEmailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("welcome_email_date");
            });

            modelBuilder.Entity<ParticipantQualFunding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("participant_qual_funding");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartFundingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("part_funding_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.QualOrderId).HasColumnName("qual_order_id");

                entity.Property(e => e.QualStateFundingId).HasColumnName("qual_state_funding_id");
            });

            modelBuilder.Entity<ParticipantStatusChange>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("participant_status_changes");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.NewProgramId).HasColumnName("new_program_id");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.OldProgramId).HasColumnName("old_program_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Reported)
                    .HasColumnType("datetime")
                    .HasColumnName("reported");

                entity.Property(e => e.ReportedAsWithdrawn).HasColumnName("reported_as_withdrawn");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<ParticipantTransferred>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.ProgramId });

                entity.ToTable("participant_transferred");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.Report)
                    .HasColumnName("report")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PasswordList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_list");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Pblog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PBLog");

                entity.Property(e => e.Column)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewData)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldData)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Table)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcsReported>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PCs_Reported");

                entity.Property(e => e.D)
                    .HasColumnType("datetime")
                    .HasColumnName("d");

                entity.Property(e => e.Fmi).HasColumnName("fmi");

                entity.Property(e => e.P).HasColumnName("p");

                entity.Property(e => e.Pc).HasColumnName("pc");

                entity.Property(e => e.RecId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REC_ID");
            });

            modelBuilder.Entity<PdpReminder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pdp_reminder");

                entity.Property(e => e.D7).HasColumnName("d7");

                entity.Property(e => e.D7Freq)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("d7_freq");

                entity.Property(e => e.Dw).HasColumnName("dw");

                entity.Property(e => e.DwFreq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dw_freq");

                entity.Property(e => e.Ii).HasColumnName("ii");

                entity.Property(e => e.IiFreq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ii_freq");

                entity.Property(e => e.Ml).HasColumnName("ml");

                entity.Property(e => e.MlFreq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ml_freq");

                entity.Property(e => e.PGoal).HasColumnName("p_goal");

                entity.Property(e => e.PGoalSteps).HasColumnName("p_goal_steps");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Qww).HasColumnName("qww");

                entity.Property(e => e.QwwSteps).HasColumnName("qww_steps");

                entity.Property(e => e.ReminderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("reminder_id");

                entity.Property(e => e.ToCoach).HasColumnName("to_coach");

                entity.Property(e => e.ToMm).HasColumnName("to_mm");

                entity.Property(e => e.ToParticipant).HasColumnName("to_participant");

                entity.Property(e => e.Wpp).HasColumnName("wpp");

                entity.Property(e => e.WppSteps).HasColumnName("wpp_steps");
            });

            modelBuilder.Entity<PdpTool>(entity =>
            {
                entity.ToTable("pdp_tools");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<PdpdiasNomination>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.Fullname, e.Email });

                entity.ToTable("pdpdias_nomination");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.NomId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("nom_id");
            });

            modelBuilder.Entity<PerformanceCriterion>(entity =>
            {
                entity.HasKey(e => e.PerformanceCriteriaId)
                    .HasName("PK88")
                    .IsClustered(false);

                entity.ToTable("performance_criteria");

                entity.HasIndex(e => e.ElementId, "IDX_element_id");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.PerformanceCriteriaDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_desc");

                entity.Property(e => e.PerformanceCriteriaRange)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_range");

                entity.Property(e => e.PerformanceCriteriaRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_ref");

                entity.HasOne(d => d.Element)
                    .WithMany(p => p.PerformanceCriteria)
                    .HasForeignKey(d => d.ElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refelement124");
            });

            modelBuilder.Entity<PerformanceReview>(entity =>
            {
                entity.HasKey(e => e.PerformanceReviewId)
                    .HasName("PK83")
                    .IsClustered(false);

                entity.ToTable("performance_review");

                entity.Property(e => e.PerformanceReviewId).HasColumnName("performance_review_id");

                entity.Property(e => e.ArchivedId).HasColumnName("archived_id");

                entity.Property(e => e.Combined).HasColumnName("combined");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateArchived)
                    .HasColumnType("datetime")
                    .HasColumnName("date_archived");

                entity.Property(e => e.MmId).HasColumnName("mm_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Q1)
                    .HasMaxLength(4000)
                    .HasColumnName("q1");

                entity.Property(e => e.Q10)
                    .HasMaxLength(4000)
                    .HasColumnName("q10");

                entity.Property(e => e.Q11)
                    .HasMaxLength(4000)
                    .HasColumnName("q11");

                entity.Property(e => e.Q12)
                    .HasMaxLength(4000)
                    .HasColumnName("q12");

                entity.Property(e => e.Q13a).HasColumnName("q13a");

                entity.Property(e => e.Q13b).HasColumnName("q13b");

                entity.Property(e => e.Q13c).HasColumnName("q13c");

                entity.Property(e => e.Q14)
                    .HasMaxLength(4000)
                    .HasColumnName("q14");

                entity.Property(e => e.Q15)
                    .HasMaxLength(4000)
                    .HasColumnName("q15");

                entity.Property(e => e.Q16)
                    .HasMaxLength(4000)
                    .HasColumnName("q16");

                entity.Property(e => e.Q2)
                    .HasMaxLength(4000)
                    .HasColumnName("q2");

                entity.Property(e => e.Q3)
                    .HasMaxLength(4000)
                    .HasColumnName("q3");

                entity.Property(e => e.Q4)
                    .HasMaxLength(4000)
                    .HasColumnName("q4");

                entity.Property(e => e.Q5)
                    .HasMaxLength(4000)
                    .HasColumnName("q5");

                entity.Property(e => e.Q6)
                    .HasMaxLength(4000)
                    .HasColumnName("q6");

                entity.Property(e => e.Q7)
                    .HasMaxLength(4000)
                    .HasColumnName("q7");

                entity.Property(e => e.Q8)
                    .HasMaxLength(4000)
                    .HasColumnName("q8");

                entity.Property(e => e.Q9)
                    .HasMaxLength(4000)
                    .HasColumnName("q9");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("review_date");
            });

            modelBuilder.Entity<PerformanceReviewKpi>(entity =>
            {
                entity.HasKey(e => e.PrKpiId)
                    .HasName("PK82")
                    .IsClustered(false);

                entity.ToTable("performance_review_kpi");

                entity.Property(e => e.PrKpiId).HasColumnName("pr_kpi_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(2000)
                    .HasColumnName("comment");

                entity.Property(e => e.KpiId).HasColumnName("kpi_id");

                entity.Property(e => e.NaturePr)
                    .HasMaxLength(4000)
                    .HasColumnName("nature_pr");

                entity.Property(e => e.PerformanceReviewId).HasColumnName("performance_review_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.Kpi)
                    .WithMany(p => p.PerformanceReviewKpis)
                    .HasForeignKey(d => d.KpiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refkpi110");
            });

            modelBuilder.Entity<PipedriveCourseUpdate>(entity =>
            {
                entity.HasKey(e => e.PipedriveId);

                entity.ToTable("pipedrive_course_updates");

                entity.Property(e => e.PipedriveId)
                    .ValueGeneratedNever()
                    .HasColumnName("pipedrive_id");

                entity.Property(e => e.Coach)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coach");

                entity.Property(e => e.Graduation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("graduation");

                entity.Property(e => e.LastCourse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_course");

                entity.Property(e => e.Mm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mm");

                entity.Property(e => e.Overview)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("overview");

                entity.Property(e => e.PastCourses)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("past_courses");
            });

            modelBuilder.Entity<PipedriveSync>(entity =>
            {
                entity.HasKey(e => e.PipedriveId);

                entity.ToTable("pipedrive_sync");

                entity.Property(e => e.PipedriveId)
                    .ValueGeneratedNever()
                    .HasColumnName("pipedrive_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.LastGrad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("last_grad");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PdTags)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pd_tags");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PipedriveUpdate>(entity =>
            {
                entity.ToTable("pipedrive_updates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Field)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("field");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("new_value");

                entity.Property(e => e.OldValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_value");

                entity.Property(e => e.PipedriveId).HasColumnName("pipedrive_id");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<PlanOfAction>(entity =>
            {
                entity.HasKey(e => e.PlanOfActionId)
                    .HasName("PK86")
                    .IsClustered(false);

                entity.ToTable("plan_of_action");

                entity.HasIndex(e => new { e.CourseCode, e.Title }, "ak_poa")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.PlanOfActionId).HasColumnName("plan_of_action_id");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course_code");

                entity.Property(e => e.PoaDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("poa_desc");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<PositionDesc>(entity =>
            {
                entity.HasKey(e => e.PositionDescId)
                    .HasName("PK84")
                    .IsClustered(false);

                entity.ToTable("position_desc");

                entity.HasIndex(e => new { e.ParticipantId, e.Field }, "ak_position_desc_1")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.PositionDescId).HasColumnName("position_desc_id");

                entity.Property(e => e.Field)
                    .HasMaxLength(50)
                    .HasColumnName("field");

                entity.Property(e => e.FieldValue)
                    .HasMaxLength(2000)
                    .HasColumnName("field_value");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PositionDescType)
                    .HasMaxLength(20)
                    .HasColumnName("position_desc_type");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.PositionDescs)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("Refparticipant114");
            });

            modelBuilder.Entity<Possible>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("possibles");

                entity.Property(e => e.CatscanLicenseId).HasColumnName("catscan_license_id");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<PowerThought>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("power_thoughts");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.PtAuthor)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("pt_author");

                entity.Property(e => e.PtId).HasColumnName("pt_id");

                entity.Property(e => e.PtText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("pt_text");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.ToTable("program");

                entity.HasIndex(e => e.CourseId, "IDX_course_id");

                entity.HasIndex(e => e.GraduationDate, "IDX_graduation_date");

                entity.HasIndex(e => e.OverviewDate, "IDX_overview_date");

                entity.HasIndex(e => e.ProgramId, "PK12")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .HasColumnName("address");

                entity.Property(e => e.AddressFup)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address_fup");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.BuildingName)
                    .HasMaxLength(250)
                    .HasColumnName("building_name");

                entity.Property(e => e.CateringCosts)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("catering_costs");

                entity.Property(e => e.CertGivenEmailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cert_given_email_date");

                entity.Property(e => e.CertificateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_created");

                entity.Property(e => e.CoFacilitatorUserId).HasColumnName("co_facilitator_user_id");

                entity.Property(e => e.Cofacilitator)
                    .HasMaxLength(100)
                    .HasColumnName("cofacilitator");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetailsOfOthers)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("details_of_others");

                entity.Property(e => e.DetailsOfOthersMcr)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("details_of_others_mcr");

                entity.Property(e => e.DisableEmail)
                    .HasColumnName("disable_email")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayLocationNote).HasColumnName("display_location_note");

                entity.Property(e => e.FacFee).HasColumnName("fac_fee");

                entity.Property(e => e.Facilitator)
                    .HasMaxLength(100)
                    .HasColumnName("facilitator");

                entity.Property(e => e.FacilitatorUserId).HasColumnName("facilitator_user_id");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.InHouse).HasColumnName("in_house");

                entity.Property(e => e.IsConfirmed)
                    .IsRequired()
                    .HasColumnName("is_confirmed")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDualQual).HasColumnName("is_dual_qual");

                entity.Property(e => e.IsVirtual).HasColumnName("is_virtual");

                entity.Property(e => e.LatestAssessmentDueDateCalculatedAkaPst)
                    .HasColumnType("datetime")
                    .HasColumnName("latest_assessment_due_date_calculated_akaPST");

                entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .HasColumnName("location_name");

                entity.Property(e => e.LocationNote)
                    .HasMaxLength(4000)
                    .HasColumnName("location_note");

                entity.Property(e => e.MapName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("map_name");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.MmOrObserverUnitSignoffReq).HasColumnName("MM_or_Observer_Unit_Signoff_Req");

                entity.Property(e => e.NotAccredited).HasColumnName("not_accredited");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasColumnName("notes");

                entity.Property(e => e.NumberOfModules).HasColumnName("number_of_modules");

                entity.Property(e => e.Observer2Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("observer2_type");

                entity.Property(e => e.Observer2UserId).HasColumnName("observer2_user_id");

                entity.Property(e => e.ObserverType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("observer_type");

                entity.Property(e => e.OldLicenseeId)
                    .HasColumnName("old_licensee_id")
                    .HasComment("Column can be deleted after 01/07/2010");

                entity.Property(e => e.OnlineModules)
                    .HasColumnName("online_modules")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherCosts)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("other_costs");

                entity.Property(e => e.OtherCostsMcr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("other_costs_mcr");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PartFirstPay).HasColumnName("part_first_pay");

                entity.Property(e => e.PartSecondPay).HasColumnName("part_second_pay");

                entity.Property(e => e.PdpDias).HasColumnName("pdp_dias");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .HasColumnName("post_code");

                entity.Property(e => e.PpbId).HasColumnName("ppb_id");

                entity.Property(e => e.QiSurvey).HasColumnName("qi_survey");

                entity.Property(e => e.RoomHireCosts)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("room_hire_costs");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .HasColumnName("state_code");

                entity.Property(e => e.StreetName)
                    .HasMaxLength(250)
                    .HasColumnName("street_name");

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(250)
                    .HasColumnName("street_number");

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .HasColumnName("suburb");

                entity.Property(e => e.TableSize).HasColumnName("table_size");

                entity.Property(e => e.TotalRoomHire)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("total_room_hire");

                entity.Property(e => e.UnitDetails)
                    .HasMaxLength(250)
                    .HasColumnName("unit_details");
            });

            modelBuilder.Entity<ProgramApproval>(entity =>
            {
                entity.HasKey(e => e.ProgramId)
                    .HasName("PK12_1")
                    .IsClustered(false);

                entity.ToTable("program_approval");

                entity.Property(e => e.ProgramId)
                    .ValueGeneratedNever()
                    .HasColumnName("program_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasColumnName("address");

                entity.Property(e => e.AddressFup)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address_fup");

                entity.Property(e => e.BuildingName)
                    .HasMaxLength(250)
                    .HasColumnName("building_name");

                entity.Property(e => e.DisableEmail).HasColumnName("disable_email");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .HasColumnName("location_name");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasColumnName("notes");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .HasColumnName("post_code");

                entity.Property(e => e.PpbId).HasColumnName("ppb_id");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("datetime")
                    .HasColumnName("request_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Requestor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("requestor");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .HasColumnName("state_code");

                entity.Property(e => e.StreetName)
                    .HasMaxLength(250)
                    .HasColumnName("street_name");

                entity.Property(e => e.StreetNumber)
                    .HasMaxLength(250)
                    .HasColumnName("street_number");

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .HasColumnName("suburb");

                entity.Property(e => e.UnitDetails)
                    .HasMaxLength(250)
                    .HasColumnName("unit_details");

                entity.HasOne(d => d.Program)
                    .WithOne(p => p.ProgramApproval)
                    .HasForeignKey<ProgramApproval>(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refprogram82");
            });

            modelBuilder.Entity<ProgramLeadWave>(entity =>
            {
                entity.HasKey(e => e.LeadWaveId);

                entity.ToTable("program_lead_wave");

                entity.Property(e => e.LeadWaveId).HasColumnName("lead_wave_id");

                entity.Property(e => e.MinWorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("min_workshop_date");

                entity.Property(e => e.Wave).HasColumnName("wave");
            });

            modelBuilder.Entity<QldFundedParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QLD_funded_participants");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<QualFundingMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qual_funding_matrix");

                entity.Property(e => e.ActiveDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("active_date");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.LocaleId).HasColumnName("locale_id");

                entity.Property(e => e.QualOrderId).HasColumnName("qual_order_id");

                entity.Property(e => e.QualStateFundingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("qual_state_funding_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");
            });

            modelBuilder.Entity<QualHour>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qual_hours");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.DualQual).HasColumnName("dual_qual");

                entity.Property(e => e.DualQualDorS)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dual_qual_DorS")
                    .IsFixedLength(true);

                entity.Property(e => e.Push)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("PUSH");

                entity.Property(e => e.QualHoursId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("qual_hours_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.ToTable("qualification");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.AntaCourseCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.AnzscoIdentifier)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ANZSCO_identifier");

                entity.Property(e => e.CpsNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cps_number");

                entity.Property(e => e.FoeIdentifier)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FOE_identifier");

                entity.Property(e => e.GovtContribution)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("govt_contribution");

                entity.Property(e => e.LoeIdentifier)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LOE_identifier");

                entity.Property(e => e.NextQualLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("next_qual_level");

                entity.Property(e => e.NominalHoursAct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_act");

                entity.Property(e => e.NominalHoursNsw)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_nsw");

                entity.Property(e => e.NominalHoursNt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_nt");

                entity.Property(e => e.NominalHoursQld)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_qld");

                entity.Property(e => e.NominalHoursSa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_sa");

                entity.Property(e => e.NominalHoursTas)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_tas");

                entity.Property(e => e.NominalHoursVic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_vic");

                entity.Property(e => e.NominalHoursWa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nominal_hours_wa");

                entity.Property(e => e.QualCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qual_code");

                entity.Property(e => e.QualLevel).HasColumnName("qual_level");

                entity.Property(e => e.QualLevelTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qual_level_title");

                entity.Property(e => e.QualStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qual_status");

                entity.Property(e => e.QualTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("qual_title");
            });

            modelBuilder.Entity<QualificationFmiUnitLu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("qualification_fmi_unit_LU");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.QualFuId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("qual_fu_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CourseCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Course_Code");

                entity.Property(e => e.McrPcr)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MCR_PCR")
                    .IsFixedLength(true);

                entity.Property(e => e.QtypeCourseId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("QType_Course_ID");

                entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");
            });

            modelBuilder.Entity<Recognition>(entity =>
            {
                entity.HasKey(e => e.RecognitionId)
                    .HasName("recognitionpk")
                    .IsClustered(false);

                entity.ToTable("recognition");

                entity.Property(e => e.RecognitionId).HasColumnName("recognition_id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.RecognitionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("recognition_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Recognitions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refusers141");
            });

            modelBuilder.Entity<Referrer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("referrer");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ReferrerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("referrer_id");

                entity.Property(e => e.ReportToStateId).HasColumnName("report_to_state_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<RelatedPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("related_persons");

                entity.HasIndex(e => new { e.ParticipantId, e.UserId, e.RoleTypeCode }, "PK32")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastViewed)
                    .HasColumnType("datetime")
                    .HasColumnName("last_viewed");

                entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");

                entity.Property(e => e.OldUserId)
                    .HasColumnName("old_user_id")
                    .HasComment("Column can be deleted after 01/07/2010");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PpbId).HasColumnName("ppb_id");

                entity.Property(e => e.RoleTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("role_type_code");

                entity.Property(e => e.TeamViewNom1).HasColumnName("TeamView_nom_1");

                entity.Property(e => e.TeamViewNom2).HasColumnName("TeamView_nom_2");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WelcomeEmailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("welcome_email_date");
            });

            modelBuilder.Entity<ReportToOption>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("report_to_options");

                entity.Property(e => e.ReportToId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("report_to_id");

                entity.Property(e => e.ReportToName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("report_to_name");
            });

            modelBuilder.Entity<ReportingSpreadsheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReportingSpreadsheet");

                entity.Property(e => e.CertificateWaiver)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Certificate Waiver");

                entity.Property(e => e.CommencementDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Commencement Date");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(2000)
                    .HasColumnName("company_name");

                entity.Property(e => e.CourseState)
                    .HasMaxLength(20)
                    .HasColumnName("Course State");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("End Date");

                entity.Property(e => e.EvidenceDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Evidence Date");

                entity.Property(e => e.Exclude)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ExcludeFromReport)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Exclude from Report");

                entity.Property(e => e.ExcludeFromTpMissingEmail).HasColumnName("exclude_from_TP_missing_email");

                entity.Property(e => e.FedFunding)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fed Funding");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("First Name");

                entity.Property(e => e.InHouse).HasColumnName("in_house");

                entity.Property(e => e.IncludeInNatFilesIfNoTp).HasColumnName("include_in_NAT_files_if_no_TP");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("Last Name");

                entity.Property(e => e.OverrideState)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Override State");

                entity.Property(e => e.OverviewDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Overview Date");

                entity.Property(e => e.ParticipantId).HasColumnName("ParticipantID");

                entity.Property(e => e.QualCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Report To");

                entity.Property(e => e.SalesPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sales_person");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Start Date");

                entity.Property(e => e.StateFunding)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("State Funding");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusChangeDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingOccursAtWorkplace).HasColumnName("training_occurs_at_workplace");

                entity.Property(e => e.UnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Unit Code");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.VettrakId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VETtrak_id");

                entity.Property(e => e.YearWithdrawn).HasColumnName("Year Withdrawn");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("review");

                entity.HasIndex(e => new { e.UserId, e.ParticipantId }, "pk40_1")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.BulletinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bulletin_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WinWinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("win_win_date");
            });

            modelBuilder.Entity<ReviewFeedback>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("review_feedback");

                entity.HasIndex(e => new { e.UserId, e.WorkshopId, e.ParticipantId }, "pk40_2")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("review_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<ReviewQuestion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("review_question");

                entity.HasIndex(e => e.ReviewQuestionId, "PK28")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.CourseId, e.Section, e.Item }, "ak28")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.QuestionPost)
                    .HasMaxLength(2000)
                    .HasColumnName("question_post");

                entity.Property(e => e.QuestionPre)
                    .HasMaxLength(2000)
                    .HasColumnName("question_pre");

                entity.Property(e => e.ResponseLength).HasColumnName("response_length");

                entity.Property(e => e.ReviewQuestionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("review_question_id");

                entity.Property(e => e.Section).HasColumnName("section");
            });

            modelBuilder.Entity<RoleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("role_type");

                entity.HasIndex(e => e.RoleTypeCode, "PK24")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.IsCoach)
                    .HasColumnName("is_coach")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsLicensee)
                    .HasColumnName("is_licensee")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsManagermentor)
                    .HasColumnName("is_managermentor")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsObserver).HasColumnName("is_observer");

                entity.Property(e => e.RoleTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("role_type_code");

                entity.Property(e => e.RoleTypeDesc)
                    .HasMaxLength(200)
                    .HasColumnName("role_type_desc");
            });

            modelBuilder.Entity<Rpl>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.FmiUnitId, e.QualificationId });

                entity.ToTable("rpl");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.Agreed).HasColumnName("agreed");

                entity.Property(e => e.AssessorId).HasColumnName("assessor_id");

                entity.Property(e => e.AutoAssessed).HasColumnName("auto_assessed");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditTransfer)
                    .HasColumnName("credit_transfer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Demonstration).HasColumnName("demonstration");

                entity.Property(e => e.FormalQual).HasColumnName("formal_qual");

                entity.Property(e => e.InterviewQues).HasColumnName("interview_ques");

                entity.Property(e => e.Observation).HasColumnName("observation");

                entity.Property(e => e.Portfolio).HasColumnName("portfolio");

                entity.Property(e => e.PositionDesc).HasColumnName("position_desc");

                entity.Property(e => e.Resume).HasColumnName("resume");

                entity.Property(e => e.SelfAssessment).HasColumnName("self_assessment");

                entity.Property(e => e.ThirdPartyRpt).HasColumnName("third_party_rpt");

                entity.Property(e => e.WorkSamples).HasColumnName("work_samples");
            });

            modelBuilder.Entity<SaleType>(entity =>
            {
                entity.ToTable("sale_type");

                entity.Property(e => e.SaleTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("sale_type_id");

                entity.Property(e => e.SaleType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sale_type");
            });

            modelBuilder.Entity<ScheduledHour>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("scheduled_hours");

                entity.Property(e => e.ActiveFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("active_from");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.ScheduledHours)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("scheduled_hours");

                entity.Property(e => e.ScheduledHoursId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ScheduledHoursID");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("settings");

                entity.Property(e => e.SettingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("setting_id");

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setting_name");

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setting_value");
            });

            modelBuilder.Entity<ShowActivityByProgram>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.ActivityId });

                entity.ToTable("show_activity_by_program");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            });

            modelBuilder.Entity<SpCall>(entity =>
            {
                entity.ToTable("sp_call");

                entity.Property(e => e.SpCallId).HasColumnName("sp_call_id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SpName)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasColumnName("sp_name");

                entity.Property(e => e.SpParams)
                    .IsRequired()
                    .HasColumnName("sp_params");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.StateCode)
                    .HasName("PK62")
                    .IsClustered(false);

                entity.ToTable("state");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .HasColumnName("state_code");

                entity.Property(e => e.State1)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.Property(e => e.StateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("state_id");
            });

            modelBuilder.Entity<StateFundingSourceCode>(entity =>
            {
                entity.HasKey(e => new { e.ParticipantId, e.QualificationId });

                entity.ToTable("state_funding_source_code");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.SfscId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sfsc_id");
            });

            modelBuilder.Entity<StatusNowType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("status_now_types");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("subscription");

                entity.Property(e => e.SubscriptionId)
                    .HasColumnName("subscription_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.A1).HasColumnName("a1");

                entity.Property(e => e.A10).HasColumnName("a10");

                entity.Property(e => e.A2).HasColumnName("a2");

                entity.Property(e => e.A3).HasColumnName("a3");

                entity.Property(e => e.A4).HasColumnName("a4");

                entity.Property(e => e.A5).HasColumnName("a5");

                entity.Property(e => e.A6).HasColumnName("a6");

                entity.Property(e => e.A7).HasColumnName("a7");

                entity.Property(e => e.A8).HasColumnName("a8");

                entity.Property(e => e.A9).HasColumnName("a9");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Lead)
                    .HasColumnName("lead")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadIdBus).HasColumnName("lead_id_bus");

                entity.Property(e => e.LeadIdEmp).HasColumnName("lead_id_emp");

                entity.Property(e => e.LeadIdMgr).HasColumnName("lead_id_mgr");

                entity.Property(e => e.LeadRequest)
                    .HasColumnType("datetime")
                    .HasColumnName("lead_request");

                entity.Property(e => e.LeadSurveyVersion).HasColumnName("lead_survey_version");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Newsletter)
                    .HasColumnName("newsletter")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<SubscriptionBackup>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("subscription_backup");

                entity.Property(e => e.SubscriptionId)
                    .HasColumnName("subscription_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.A1).HasColumnName("a1");

                entity.Property(e => e.A10).HasColumnName("a10");

                entity.Property(e => e.A2).HasColumnName("a2");

                entity.Property(e => e.A3).HasColumnName("a3");

                entity.Property(e => e.A4).HasColumnName("a4");

                entity.Property(e => e.A5).HasColumnName("a5");

                entity.Property(e => e.A6).HasColumnName("a6");

                entity.Property(e => e.A7).HasColumnName("a7");

                entity.Property(e => e.A8).HasColumnName("a8");

                entity.Property(e => e.A9).HasColumnName("a9");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Lead)
                    .HasColumnName("lead")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadIdBus).HasColumnName("lead_id_bus");

                entity.Property(e => e.LeadIdEmp).HasColumnName("lead_id_emp");

                entity.Property(e => e.LeadIdMgr).HasColumnName("lead_id_mgr");

                entity.Property(e => e.LeadRequest)
                    .HasColumnType("datetime")
                    .HasColumnName("lead_request");

                entity.Property(e => e.LeadSurveyVersion).HasColumnName("lead_survey_version");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Newsletter)
                    .HasColumnName("newsletter")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Suitability>(entity =>
            {
                entity.HasKey(e => e.ParticipantId);

                entity.ToTable("suitability");

                entity.Property(e => e.ParticipantId)
                    .ValueGeneratedNever()
                    .HasColumnName("participant_id");

                entity.Property(e => e.Achieve)
                    .HasMaxLength(400)
                    .HasColumnName("achieve");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1000)
                    .HasColumnName("comments");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Goals)
                    .HasMaxLength(400)
                    .HasColumnName("goals");

                entity.Property(e => e.InternetAccess)
                    .HasMaxLength(400)
                    .HasColumnName("internet_access");

                entity.Property(e => e.OtherInterests)
                    .HasMaxLength(400)
                    .HasColumnName("other_interests");

                entity.Property(e => e.Position)
                    .HasMaxLength(400)
                    .HasColumnName("position");

                entity.Property(e => e.Suitable).HasColumnName("suitable");

                entity.Property(e => e.UseComputer)
                    .HasMaxLength(400)
                    .HasColumnName("use_computer");

                entity.HasOne(d => d.Participant)
                    .WithOne(p => p.Suitability)
                    .HasForeignKey<Suitability>(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_suitability_participant");
            });

            modelBuilder.Entity<TeamView>(entity =>
            {
                entity.ToTable("TeamView");

                entity.Property(e => e.TeamViewId).HasColumnName("TeamView_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_update");

                entity.Property(e => e.MmUserId).HasColumnName("mm_user_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q10).HasColumnName("q10");

                entity.Property(e => e.Q11).HasColumnName("q11");

                entity.Property(e => e.Q12).HasColumnName("q12");

                entity.Property(e => e.Q13).HasColumnName("q13");

                entity.Property(e => e.Q14).HasColumnName("q14");

                entity.Property(e => e.Q15).HasColumnName("q15");

                entity.Property(e => e.Q16).HasColumnName("q16");

                entity.Property(e => e.Q17).HasColumnName("q17");

                entity.Property(e => e.Q18).HasColumnName("q18");

                entity.Property(e => e.Q19).HasColumnName("q19");

                entity.Property(e => e.Q2).HasColumnName("q2");

                entity.Property(e => e.Q20).HasColumnName("q20");

                entity.Property(e => e.Q21).HasColumnName("q21");

                entity.Property(e => e.Q22).HasColumnName("q22");

                entity.Property(e => e.Q23).HasColumnName("q23");

                entity.Property(e => e.Q24).HasColumnName("q24");

                entity.Property(e => e.Q25).HasColumnName("q25");

                entity.Property(e => e.Q26).HasColumnName("q26");

                entity.Property(e => e.Q27).HasColumnName("q27");

                entity.Property(e => e.Q28).HasColumnName("q28");

                entity.Property(e => e.Q29).HasColumnName("q29");

                entity.Property(e => e.Q3).HasColumnName("q3");

                entity.Property(e => e.Q30).HasColumnName("q30");

                entity.Property(e => e.Q31).HasColumnName("q31");

                entity.Property(e => e.Q32).HasColumnName("q32");

                entity.Property(e => e.Q33).HasColumnName("q33");

                entity.Property(e => e.Q34).HasColumnName("q34");

                entity.Property(e => e.Q35).HasColumnName("q35");

                entity.Property(e => e.Q36).HasColumnName("q36");

                entity.Property(e => e.Q37).HasColumnName("q37");

                entity.Property(e => e.Q4).HasColumnName("q4");

                entity.Property(e => e.Q5).HasColumnName("q5");

                entity.Property(e => e.Q6).HasColumnName("q6");

                entity.Property(e => e.Q7).HasColumnName("q7");

                entity.Property(e => e.Q8).HasColumnName("q8");

                entity.Property(e => e.Q9).HasColumnName("q9");

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .HasComment("1: Participant; 2: Manager/Mentor;");

                entity.Property(e => e.Stage).HasColumnName("stage");

                entity.Property(e => e.Ukey).HasColumnName("ukey");

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TEST");
            });

            modelBuilder.Entity<TestActDump>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("test_act_dump");

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("account_type");

                entity.Property(e => e.AmountPaid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("amount_paid");

                entity.Property(e => e.CatscanId).HasColumnName("catscan_id");

                entity.Property(e => e.CertificateIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_issued");

                entity.Property(e => e.Coach)
                    .HasMaxLength(101)
                    .HasColumnName("coach");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.InHouse).HasColumnName("in_house");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Managermentor)
                    .HasMaxLength(101)
                    .HasColumnName("managermentor");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Testimonials");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .HasColumnName("Company Name");

                entity.Property(e => e.Course)
                    .HasMaxLength(20)
                    .HasColumnName("course");

                entity.Property(e => e.CourseLocation)
                    .HasMaxLength(100)
                    .HasColumnName("Course Location");

                entity.Property(e => e.Feedback).IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("First Name");

                entity.Property(e => e.Industry)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("Last Name");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Overview Date");

                entity.Property(e => e.State).HasMaxLength(20);
            });

            modelBuilder.Entity<Tool>(entity =>
            {
                entity.HasKey(e => e.ToolId)
                    .HasName("PK80")
                    .IsClustered(false);

                entity.ToTable("tool");

                entity.HasIndex(e => new { e.ParticipantId, e.ToolType, e.Field }, "tool_ak1")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ToolId).HasColumnName("tool_id");

                entity.Property(e => e.ArchivedId).HasColumnName("archived_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateArchived)
                    .HasColumnType("datetime")
                    .HasColumnName("date_archived");

                entity.Property(e => e.Field)
                    .HasMaxLength(20)
                    .HasColumnName("field");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ToolType)
                    .HasMaxLength(20)
                    .HasColumnName("tool_type");

                entity.Property(e => e.ToolValue).HasColumnName("tool_value");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.Tools)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipant108");
            });

            modelBuilder.Entity<Tool1>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.ActivityId });

                entity.ToTable("tools");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            });

            modelBuilder.Entity<TrainingPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("training_plan");

                entity.Property(e => e.CommencementDate)
                    .HasColumnType("datetime")
                    .HasColumnName("commencement_date");

                entity.Property(e => e.CompletionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("completion_date");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Duration)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("duration");

                entity.Property(e => e.ExcludeFromTpMissingEmail).HasColumnName("exclude_from_TP_missing_email");

                entity.Property(e => e.Fulltime).HasColumnName("fulltime");

                entity.Property(e => e.LastEdited)
                    .HasColumnType("datetime")
                    .HasColumnName("last_edited");

                entity.Property(e => e.LastEditedBy).HasColumnName("last_edited_by");

                entity.Property(e => e.LmaRepAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("lma_rep_agree");

                entity.Property(e => e.LmaRepFirstAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("lma_rep_first_agree");

                entity.Property(e => e.LmaRepFullName)
                    .HasMaxLength(200)
                    .HasColumnName("lma_rep_full_name");

                entity.Property(e => e.MmAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_agree");

                entity.Property(e => e.MmContractCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_contract_completed");

                entity.Property(e => e.MmFirstAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_first_agree");

                entity.Property(e => e.MmFullName)
                    .HasMaxLength(200)
                    .HasColumnName("mm_full_name");

                entity.Property(e => e.MmSignoff)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_signoff");

                entity.Property(e => e.NewTpRequired)
                    .HasColumnType("datetime")
                    .HasColumnName("new_tp_required");

                entity.Property(e => e.PartAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("part_agree");

                entity.Property(e => e.PartFirstAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("part_first_agree");

                entity.Property(e => e.PartFullName)
                    .HasMaxLength(200)
                    .HasColumnName("part_full_name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PdfCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("pdf_created");

                entity.Property(e => e.Position)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.PropCompletionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("prop_completion_date")
                    .HasComment("Proposed Completion Date on Training Plan under \"RTO details\". Get refocus_date if this field is NULL");

                entity.Property(e => e.SignoffEmailSent)
                    .HasColumnType("datetime")
                    .HasColumnName("signoff_email_sent");

                entity.Property(e => e.TpId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TP_Id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<TrainingPlanTemp>(entity =>
            {
                entity.HasKey(e => e.ParticipantId);

                entity.ToTable("training_plan_temp");

                entity.Property(e => e.ParticipantId)
                    .ValueGeneratedNever()
                    .HasColumnName("participant_id");

                entity.Property(e => e.LmaRepAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("lma_rep_agree");

                entity.Property(e => e.MmAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("mm_agree");

                entity.Property(e => e.PartAgree)
                    .HasColumnType("datetime")
                    .HasColumnName("part_agree");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.FirstName, "IDX_first_name");

                entity.HasIndex(e => e.LastName, "IDX_last_name");

                entity.HasIndex(e => e.UserId, "PK22")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.UserId, e.LogonId }, "users_1")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ActLicenseeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("act_licensee_name");

                entity.Property(e => e.AddressToSendCert)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("address_to_send_cert");

                entity.Property(e => e.BusinessPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("business_phone");

                entity.Property(e => e.Coach)
                    .HasColumnName("coach")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CompanyAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("company_address_1");

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("company_address_2");

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(100)
                    .HasColumnName("company_city");

                entity.Property(e => e.CompanyPostcode)
                    .HasMaxLength(20)
                    .HasColumnName("company_postcode");

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(20)
                    .HasColumnName("company_state");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.EmailAlt)
                    .HasMaxLength(200)
                    .HasColumnName("email_alt");

                entity.Property(e => e.EmailFormat).HasColumnName("email_format");

                entity.Property(e => e.EmailSignature).HasColumnName("email_signature");

                entity.Property(e => e.Facilitator).HasColumnName("facilitator");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .HasColumnName("fax");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.HomeAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("home_address_1");

                entity.Property(e => e.HomeAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("home_address_2");

                entity.Property(e => e.HomeCity)
                    .HasMaxLength(100)
                    .HasColumnName("home_city");

                entity.Property(e => e.HomePostcode)
                    .HasMaxLength(20)
                    .HasColumnName("home_postcode");

                entity.Property(e => e.HomeState)
                    .HasMaxLength(20)
                    .HasColumnName("home_state");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(120)
                    .HasColumnName("job_title");

                entity.Property(e => e.LastLogonDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_logon_date");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LegalMiddleName)
                    .HasMaxLength(200)
                    .HasColumnName("legal_middle_name");

                entity.Property(e => e.Licensee)
                    .HasColumnName("licensee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LogonId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("logon_id");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.NationalStudentNumber)
                    .HasMaxLength(30)
                    .HasColumnName("national_student_number");

                entity.Property(e => e.OtherCountries)
                    .HasMaxLength(100)
                    .HasColumnName("Other_countries");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.PotwPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("potw_password");

                entity.Property(e => e.PotwUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("potw_user");

                entity.Property(e => e.PpiLink)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ppi_link");

                entity.Property(e => e.PreferredFirstName)
                    .HasMaxLength(200)
                    .HasColumnName("preferred_first_name");

                entity.Property(e => e.PreferredLastName)
                    .HasMaxLength(200)
                    .HasColumnName("preferred_last_name");

                entity.Property(e => e.RecognitionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("recognition_date");

                entity.Property(e => e.RecognitionNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("recognition_notes");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.Usi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USI");

                entity.Property(e => e.UsiFirstNames)
                    .HasMaxLength(80)
                    .HasColumnName("USI_first_names");

                entity.Property(e => e.UsiLastName)
                    .HasMaxLength(80)
                    .HasColumnName("USI_last_name");

                entity.Property(e => e.UsiNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("USI_Notes");

                entity.Property(e => e.UsiVerified).HasColumnName("USI_Verified");

                entity.Property(e => e.VettrakId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VETtrak_id");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_addresses");

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("address_line");

                entity.Property(e => e.AddressNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address_number");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("building");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Line1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("line1");

                entity.Property(e => e.Line2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("line2");

                entity.Property(e => e.OtherCountries)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Other_countries");

                entity.Property(e => e.PostalAddressLine)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("postal_address_line");

                entity.Property(e => e.PostalAddressNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("postal_address_number");

                entity.Property(e => e.PostalBox)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("postal_box");

                entity.Property(e => e.PostalBuilding)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("postal_building");

                entity.Property(e => e.PostalPostcode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("postal_postcode");

                entity.Property(e => e.PostalState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("postal_state");

                entity.Property(e => e.PostalTown)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("postal_town");

                entity.Property(e => e.PostalUnit)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("postal_unit");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tag");

                entity.Property(e => e.Town)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("town");

                entity.Property(e => e.Unit)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("unit");

                entity.Property(e => e.UserAddressId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("user_address_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Work1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("work_1");
            });

            modelBuilder.Entity<UsersOrphaned>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users_orphaned");

                entity.Property(e => e.BusinessPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("business_phone");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CompanyAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("company_address_1");

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("company_address_2");

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(100)
                    .HasColumnName("company_city");

                entity.Property(e => e.CompanyPostcode)
                    .HasMaxLength(20)
                    .HasColumnName("company_postcode");

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(20)
                    .HasColumnName("company_state");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.Facilitator).HasColumnName("facilitator");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .HasColumnName("fax");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.HomeAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("home_address_1");

                entity.Property(e => e.HomeAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("home_address_2");

                entity.Property(e => e.HomeCity)
                    .HasMaxLength(100)
                    .HasColumnName("home_city");

                entity.Property(e => e.HomePostcode)
                    .HasMaxLength(20)
                    .HasColumnName("home_postcode");

                entity.Property(e => e.HomeState)
                    .HasMaxLength(20)
                    .HasColumnName("home_state");

                entity.Property(e => e.LastLogonDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_logon_date");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Licensee).HasColumnName("licensee");

                entity.Property(e => e.LogonId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("logon_id");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.PreferredName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("preferred_name");

                entity.Property(e => e.RecognitionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("recognition_date");

                entity.Property(e => e.RecognitionNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("recognition_notes");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VActivityLesson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_activity_lesson");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("activity_title");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.LessonSeq).HasColumnName("lesson_seq");

                entity.Property(e => e.Live)
                    .HasMaxLength(50)
                    .HasColumnName("live");

                entity.Property(e => e.LiveId).HasColumnName("live_id");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .HasColumnName("module");

                entity.Property(e => e.Review)
                    .HasMaxLength(50)
                    .HasColumnName("review");

                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Submit)
                    .HasMaxLength(50)
                    .HasColumnName("submit");

                entity.Property(e => e.SubmitId).HasColumnName("submit_id");
            });

            modelBuilder.Entity<VicFundedParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIC_funded_participants");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.EvidenceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("evidence_date");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FmiUnitIdNew).HasColumnName("fmi_unit_id_New");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<VtCurrLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vt_curr_location");

                entity.Property(e => e.LocaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loca_Code");

                entity.Property(e => e.LocaId).HasColumnName("Loca_Id");

                entity.Property(e => e.LocaName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Loca_Name");
            });

            modelBuilder.Entity<VwAaagetMultiplePartId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AAAgetMultiplePart_Ids");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwActivitiesByProgram>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwActivitiesByProgram");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.LessonName)
                    .HasMaxLength(50)
                    .HasColumnName("lesson_name");

                entity.Property(e => e.LessonSeq).HasColumnName("lesson_seq");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<VwActivitiesByProgramNotInActivityMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwActivitiesByProgram_NotInActivityMatrix");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.LessonName)
                    .HasMaxLength(50)
                    .HasColumnName("lesson_name");

                entity.Property(e => e.LessonSeq).HasColumnName("lesson_seq");

                entity.Property(e => e.NullActivityId).HasColumnName("null_Activity_Id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Seq).HasColumnName("seq");
            });

            modelBuilder.Entity<VwActivityIdsByFmiUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwActivityIdsByFmiUnit");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("activity_title");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.LessonDue).HasColumnName("lesson_due");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");
            });

            modelBuilder.Entity<VwActivityIdsCourseCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwActivityIds_CourseCodes");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");
            });

            modelBuilder.Entity<VwActivityMatrixToElement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwActivityMatrixToElement");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");
            });

            modelBuilder.Entity<VwAttendedOrHadTutorial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAttendedOrHadTutorial");

                entity.Property(e => e.AttendanceWorkshopId).HasColumnName("attendance_workshop_id");

                entity.Property(e => e.Attended).HasColumnName("attended");

                entity.Property(e => e.CoachAttended).HasColumnName("Coach_attended");

                entity.Property(e => e.DateAtt)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAtt");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.MmAttended).HasColumnName("MM_attended");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(20)
                    .HasColumnName("reason_code");

                entity.Property(e => e.TutorialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tutorial_date");

                entity.Property(e => e.TutorialWith).HasColumnName("tutorial_with");

                entity.Property(e => e.WorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<VwAuditAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAuditALL");

                entity.Property(e => e.ExtractAuditType)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("extract_audit_type");

                entity.Property(e => e.ExtractAuditTypeId).HasColumnName("extract_audit_type_id");

                entity.Property(e => e.ExtractHeaderId).HasColumnName("extract_header_id");

                entity.Property(e => e.ExtractStart)
                    .HasColumnType("datetime")
                    .HasColumnName("extract_start");

                entity.Property(e => e.ExtractTageDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("extract_tage_description");

                entity.Property(e => e.InsertedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("inserted_date");

                entity.Property(e => e.IsEmailSend).HasColumnName("is_email_send");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("new_value");

                entity.Property(e => e.OtherId).HasColumnName("other_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PreviousValue)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("previous_value");

                entity.Property(e => e.SubPartId).HasColumnName("sub_part_id");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<VwCoachesByProgram>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCoachesByProgram");

                entity.Property(e => e.CoachFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("coach_first_name");

                entity.Property(e => e.CoachLastName)
                    .HasMaxLength(50)
                    .HasColumnName("coach_last_name");

                entity.Property(e => e.CoachUserId).HasColumnName("coach_user_id");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(100)
                    .HasColumnName("course_name");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.FacilitatorFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("facilitator_first_name");

                entity.Property(e => e.FacilitatorLastName)
                    .HasMaxLength(50)
                    .HasColumnName("facilitator_last_name");

                entity.Property(e => e.FacilitatorUserId).HasColumnName("facilitator_user_id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .HasColumnName("location_name");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.RoleTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("role_type_code");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WelcomeEmailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("welcome_email_date");
            });

            modelBuilder.Entity<VwCompetencyCompletedDateByParticipantId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCompetencyCompletedDateByParticipantID");

                entity.Property(e => e.CompetencyCompleted).HasColumnType("datetime");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwCourseCompWa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCourseComp_WA");

                entity.Property(e => e.ActivityDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("activity_desc");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("activity_title");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.ElementRange)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("element_range");

                entity.Property(e => e.ElementRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("element_ref");

                entity.Property(e => e.ElementTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("element_title");

                entity.Property(e => e.FacilitatorUserId).HasColumnName("facilitator_user_id");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitDesc)
                    .HasMaxLength(1000)
                    .HasColumnName("fmi_unit_desc");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FmiUnitTitle)
                    .HasMaxLength(100)
                    .HasColumnName("fmi_unit_title");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.LessonName)
                    .HasMaxLength(50)
                    .HasColumnName("lesson_name");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PerformanceCriteriaDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_desc");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");

                entity.Property(e => e.PerformanceCriteriaRange)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_range");

                entity.Property(e => e.PerformanceCriteriaRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_ref");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qual_code");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.WorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date");
            });

            modelBuilder.Entity<VwCourseToActivityKeep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCourseToActivity_KEEP");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("activity_title");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.LessonName)
                    .HasMaxLength(50)
                    .HasColumnName("lesson_name");

                entity.Property(e => e.LessonSeq).HasColumnName("lesson_seq");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("version");

                entity.Property(e => e.WorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<VwDateAchieved>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDateAchieved");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("date_achieved");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwDiscontinuedNoAchievementsParticipantId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDiscontinuedNoAchievements_ParticipantIDs");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwFacilitatorsActiveBySurnameStateYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFacilitatorsActiveBySurnameStateYear");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.GradYear).HasColumnName("Grad_Year");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.OverViewYear).HasColumnName("OverView_Year");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .HasColumnName("state_code");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwFfsonlyWip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFFSonly_WIP");

                entity.Property(e => e.AntaCourseCode)
                    .HasMaxLength(100)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(100)
                    .HasColumnName("course_name");

                entity.Property(e => e.FfsOnlyCourseId).HasColumnName("ffs_only_course_id");

                entity.Property(e => e.FfsOnlyFmiUnitId).HasColumnName("ffs_only_fmi_unit_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.ParticipantCompetencyFmiUnitId).HasColumnName("participant_competency__fmi_unit_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.SfscId).HasColumnName("sfsc_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwFirstCompetencyAchievedByParticipantId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFirstCompetencyAchievedByParticipantId");

                entity.Property(e => e.FirstAchievedDate).HasColumnType("datetime");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwFmiUnitToActivitiesByCourseId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFmiUnitToActivitiesByCourseID");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("activity_title");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.ElementTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("element_title");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FmiUnitTitle)
                    .HasMaxLength(100)
                    .HasColumnName("fmi_unit_title");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.PerformanceCriteriaDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_desc");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");
            });

            modelBuilder.Entity<VwFmiUnitToCourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFmiUnitToCourse");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FmiUnitIdUpgradedFrom).HasColumnName("fmi_unit_id_upgraded_from");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<VwFmiUnitsByFirstLessonId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFmiUnitsByFirstLessonId");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FirstLessonId).HasColumnName("first_lesson_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");
            });

            modelBuilder.Entity<VwFmiUnitsByLessonId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFmiUnitsByLessonId");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");
            });

            modelBuilder.Entity<VwHouseKeepingDuplicatePostcodesForHomeCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwHouseKeeping_duplicatePostcodesForHomeCity");

                entity.Property(e => e.CountPostcode).HasColumnName("count_postcode");

                entity.Property(e => e.HomeCity)
                    .HasMaxLength(100)
                    .HasColumnName("home_city");

                entity.Property(e => e.HomeState)
                    .HasMaxLength(20)
                    .HasColumnName("home_state");
            });

            modelBuilder.Entity<VwHouseKeepingNoPhone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwHouseKeeping_NoPhone");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(20)
                    .HasColumnName("company_state");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .HasColumnName("fax");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.HomeState)
                    .HasMaxLength(20)
                    .HasColumnName("home_state");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_home");

                entity.Property(e => e.PhoneMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_mobile");

                entity.Property(e => e.PhoneWork)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_work");

                entity.Property(e => e.PostalState)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("postal_state")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WelcomeEmailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("welcome_email_date");
            });

            modelBuilder.Entity<VwHouseKeepingPriorWithNoDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwHouseKeepingPriorWithNoDetails");

                entity.Property(e => e.AdvDiploma).HasColumnName("adv_diploma");

                entity.Property(e => e.CertI).HasColumnName("cert_i");

                entity.Property(e => e.CertIi).HasColumnName("cert_ii");

                entity.Property(e => e.CertIii).HasColumnName("cert_iii");

                entity.Property(e => e.CertIv).HasColumnName("cert_iv");

                entity.Property(e => e.CertOther).HasColumnName("cert_other");

                entity.Property(e => e.Degree).HasColumnName("degree");

                entity.Property(e => e.Diploma).HasColumnName("diploma");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PriorEducation).HasColumnName("prior_education");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwHousekeepingMismatchedDob>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwHousekeeping_MismatchedDOBs");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.EfDob)
                    .HasColumnType("datetime")
                    .HasColumnName("EF_DOB");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Usi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USI");

                entity.Property(e => e.UsiNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("USI_Notes");

                entity.Property(e => e.UsiVerified).HasColumnName("USI_Verified");
            });

            modelBuilder.Entity<VwHousekeepingParticipantEnrolmentFormWrongUserId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwHousekeeping_Participant_EnrolmentForm_WrongUserID");

                entity.Property(e => e.EnrolformUserId).HasColumnName("enrolform_user_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwLeadActivityDetailOnly>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLeadActivityDetailOnly");

                entity.Property(e => e.ActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activity_date");

                entity.Property(e => e.ActivityDetailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("activity_detail_id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.Assessed)
                    .HasColumnType("datetime")
                    .HasColumnName("assessed");

                entity.Property(e => e.Completed)
                    .HasColumnType("datetime")
                    .HasColumnName("completed");

                entity.Property(e => e.Paper).HasColumnName("paper");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ReviewerParticipantId).HasColumnName("reviewer_participant_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubmitToMm)
                    .HasColumnType("datetime")
                    .HasColumnName("submit_to_mm");

                entity.Property(e => e.WorkareaUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("workarea_url");

                entity.Property(e => e.XmlActivityData)
                    .HasColumnType("xml")
                    .HasColumnName("xml_activity_data");

                entity.Property(e => e.XmlActivityDataBackup)
                    .HasColumnType("xml")
                    .HasColumnName("xml_activity_data_backup");

                entity.Property(e => e.XmlTemplate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("xml_template");
            });

            modelBuilder.Entity<VwLeadresult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLEADresults");

                entity.Property(e => e.ActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("activity_date");

                entity.Property(e => e.ActivityDetailId).HasColumnName("activity_detail_id");

                entity.Property(e => e.Assessed)
                    .HasColumnType("datetime")
                    .HasColumnName("assessed");

                entity.Property(e => e.Completed)
                    .HasColumnType("datetime")
                    .HasColumnName("completed");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Lcid).HasColumnName("lcid");

                entity.Property(e => e.NominationType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nomination_type")
                    .IsFixedLength(true);

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SurveyRespondantEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("surveyRespondantEmail");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwListForAndrew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_List_For_Andrew");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CatscanHistoryId).HasColumnName("Catscan History ID");

                entity.Property(e => e.Client).HasMaxLength(100);

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Company Phone");

                entity.Property(e => e.DmEmail)
                    .HasMaxLength(500)
                    .HasColumnName("DM Email");

                entity.Property(e => e.DmJobTitle)
                    .HasMaxLength(500)
                    .HasColumnName("DM Job Title");

                entity.Property(e => e.DmName)
                    .HasMaxLength(500)
                    .HasColumnName("DM Name");

                entity.Property(e => e.DmPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM Phone");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiration Date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("First Name");

                entity.Property(e => e.Industry)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Last Name");

                entity.Property(e => e.Lincesee)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MmEmail)
                    .HasMaxLength(100)
                    .HasColumnName("MM Email");

                entity.Property(e => e.MmFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("MM First Name");

                entity.Property(e => e.MmLastName)
                    .HasMaxLength(50)
                    .HasColumnName("MM Last Name");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipantSPhone)
                    .HasMaxLength(20)
                    .HasColumnName("Participant's Phone");

                entity.Property(e => e.RegistrationStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Registration Status");

                entity.Property(e => e.RegistrationType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Registration Type");

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.Suburb).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User ID");
            });

            modelBuilder.Entity<VwManagerMentorInEnrolleeVersusRelatedParty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwManagerMentorInEnrolleeVersusRelatedParty");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.EnrolleeId).HasColumnName("enrollee_id");

                entity.Property(e => e.Expr1).HasMaxLength(50);

                entity.Property(e => e.Expr2).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.MmCompany)
                    .HasMaxLength(100)
                    .HasColumnName("mm_company");

                entity.Property(e => e.MmFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("mm_first_name");

                entity.Property(e => e.MmLastName)
                    .HasMaxLength(50)
                    .HasColumnName("mm_last_name");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.RoleTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("role_type_code");
            });

            modelBuilder.Entity<VwMinEvidenceDateByParticipantId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMinEvidenceDateByParticipantID");

                entity.Property(e => e.MinEviidenceDate).HasColumnType("datetime");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwModule1AttendedOrDiscontinuedIsFalse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Module1Attended_orDiscontinuedIsFalse");

                entity.Property(e => e.Attended).HasColumnName("attended");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.TutorialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tutorial_date");
            });

            modelBuilder.Entity<VwMostRecentParticipantHavingNonNullAdressByUserId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMostRecentParticipantHavingNonNullAdressByUserID");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwNswFunded>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwNSW_funded");

                entity.Property(e => e.CertReported)
                    .HasColumnType("datetime")
                    .HasColumnName("cert_reported");

                entity.Property(e => e.CertificateIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("certificate_issued");

                entity.Property(e => e.CompReported)
                    .HasColumnType("datetime")
                    .HasColumnName("comp_reported");

                entity.Property(e => e.CompetencyCompleted).HasColumnType("datetime");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.DateStatusChanged)
                    .HasColumnType("datetime")
                    .HasColumnName("dateStatusChanged");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.FederalFunding).HasColumnName("federal_funding");

                entity.Property(e => e.FirstAchievedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.McrReported)
                    .HasColumnType("datetime")
                    .HasColumnName("mcr_reported");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Reported)
                    .HasColumnType("datetime")
                    .HasColumnName("reported");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("state_code");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwPParticipantActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_p_participant_activity");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            });

            modelBuilder.Entity<VwPartCompByFirstStartDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PartCompByFirstStartDate");

                entity.Property(e => e.MinStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("min_start_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwPartCompByNumActiveAndCompletedUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PartCompByNumActiveAndCompletedUnits");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwPartCompByNumActiveUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PartCompByNumActiveUnits");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwPartCompDatesAllPlugInPartId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPartCompDatesAll_PlugInPartID");

                entity.Property(e => e.AttendedHours).HasColumnName("attended_hours");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.CurrentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_end_date");

                entity.Property(e => e.CurrentStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_start_date");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("date_achieved");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndDateExtended)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date_extended");

                entity.Property(e => e.EvidenceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("evidence_date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("graduation_date");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PreviousEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("previous_end_date");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.ProposedEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("proposed_end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwPartCompDiscontinuedWithNullEvidenceDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPartComp_Discontinued_withNullEvidenceDate");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwPartCompFirstStartDateByPartId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPartComp_FirstStartDate_ByPartId");

                entity.Property(e => e.MinStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("min_start_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwPartCompFirstStartDateNonNullEvidenceDateOnly>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPartComp_FirstStartDate_NonNullEvidenceDate_Only");

                entity.Property(e => e.MinStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("min_start_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwPartCompPrimaryQualRow>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPartCompPrimaryQualRows");

                entity.Property(e => e.Archived)
                    .HasColumnType("datetime")
                    .HasColumnName("archived");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualificationFlag)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qualification_flag");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwPartCompProgramCommencementDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPartCompProgram_CommencementDates");

                entity.Property(e => e.CommencementDate)
                    .HasColumnType("datetime")
                    .HasColumnName("commencement_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<VwPartCompSecondaryQualRow>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPartCompSecondaryQualRows");

                entity.Property(e => e.Archived)
                    .HasColumnType("datetime")
                    .HasColumnName("archived");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualificationFlag)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qualification_flag");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwPartSchedHour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Part_SchedHours");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.SumScheduleHours).HasColumnType("decimal(38, 1)");
            });

            modelBuilder.Entity<VwPartSchedHoursByUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Part_SchedHours_ByUnit");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.Numhours).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwParticipantByFirstActivityDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantByFirstActivityDate");

                entity.Property(e => e.EarliestActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("earliest_activity_date");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwParticipantCompetencyAttendedOrTuteDatePresentLast4Month>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantCompetency_AttendedOrTuteDatePresent_Last4Months");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.TutorialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tutorial_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date");
            });

            modelBuilder.Entity<VwParticipantCompetencyStartDatesFromNowMinus2Year>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantCompetencyStartDatesFromNowMinus2Years");

                entity.Property(e => e.DateAchieved)
                    .HasColumnType("datetime")
                    .HasColumnName("date_achieved");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FundingReported)
                    .HasColumnType("datetime")
                    .HasColumnName("funding_reported");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PcToReportStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pc_to_report_start_date");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.RplCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("rpl_create_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<VwParticipantCompetencyUnitCountByParticipantQualificationId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantCompetencyUnitCountByParticipantQualificationIds");

                entity.Property(e => e.PartQualUnitCount).HasColumnName("part_qual_unit_count");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");
            });

            modelBuilder.Entity<VwParticipantEndDatesFutureOnly>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantEndDates_FutureOnly");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwParticipantFmiUnitIdFirstWorkshopDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipant_FmiUnitId_FirstWorkshopDate");

                entity.Property(e => e.FirstWorkshop).HasColumnType("datetime");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwParticipantHoursWState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Participant_Hours_wState");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.NominalHours).HasColumnName("nominal_hours");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<VwParticipantReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ParticipantReport");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.FundingTypeAbbr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("funding_type_abbr");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwParticipantStartDatesFutureOnly>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantStartDates_FutureOnly");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("startDate");
            });

            modelBuilder.Entity<VwParticipantStatusChangeLatest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantStatusChangeLatest");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.NewProgramId).HasColumnName("new_program_id");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.OldProgramId).HasColumnName("old_program_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Reported)
                    .HasColumnType("datetime")
                    .HasColumnName("reported");

                entity.Property(e => e.ReportedAsWithdrawn).HasColumnName("reported_as_withdrawn");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<VwParticipantStatusChangesWithdrawn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantStatusChanges_Withdrawn");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.WithdrawnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwParticipantswithNonNullFundingReported>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticipantswithNonNullFundingReported");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            });

            modelBuilder.Entity<VwParticpantsByPcompLocationVsProgLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwParticpantsByPCompLocationVsProgLocation");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .HasColumnName("address");

                entity.Property(e => e.AntaCourseCode)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(100)
                    .HasColumnName("course_name");

                entity.Property(e => e.FundingType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("funding_type");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PcLocationId).HasColumnName("PC_Location_id");

                entity.Property(e => e.PcLocationName)
                    .HasMaxLength(100)
                    .HasColumnName("PC_LocationName");

                entity.Property(e => e.PcLocationStateCode)
                    .HasMaxLength(20)
                    .HasColumnName("PC_Location_StateCode");

                entity.Property(e => e.PrimaryQual).HasColumnName("Primary_Qual");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.ProgramLocationId).HasColumnName("ProgramLocationID");

                entity.Property(e => e.ProgramTableLocationName)
                    .HasMaxLength(100)
                    .HasColumnName("programTable_location_name");

                entity.Property(e => e.ProgramlocationLocationName)
                    .HasMaxLength(100)
                    .HasColumnName("Programlocation_locationName");

                entity.Property(e => e.ProgramlocationStatecode)
                    .HasMaxLength(20)
                    .HasColumnName("Programlocation_statecode");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.ReportTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("report_to");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(20)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<VwPrimaryQualToFunding>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPrimaryQualToFunding");

                entity.Property(e => e.AntaCourseCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.CombinedPending).HasColumnName("combined_pending");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.DualQualifications).HasColumnName("dual_qualifications");

                entity.Property(e => e.FederalFunding).HasColumnName("federal_funding");

                entity.Property(e => e.FundingType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("funding_type");

                entity.Property(e => e.FundingTypeAbbr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("funding_type_abbr");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualLevel).HasColumnName("qual_level");

                entity.Property(e => e.QualificationFlag)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qualification_flag");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.ReportTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("report_to");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwProgramActivityLessonLessonMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwProgram_ActivityLesson_Lesson_Matrix");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<VwProgramParticipantCountsNonDiscontinued>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwProgramParticipantCountsNonDiscontinued");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<VwProgramToActivitiesLessonsElementsPerfCriteriaMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwProgramToActivitiesLessonsElementsPerfCriteria_MASTER");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.ActivityTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("activity_title");

                entity.Property(e => e.AlVersion).HasColumnName("al_version");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.ElementTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("element_title");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.LessonCourseId).HasColumnName("LessonCourseID");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.LessonName)
                    .HasMaxLength(50)
                    .HasColumnName("lesson_name");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.PerformanceCriteriaDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("performance_criteria_desc");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<VwProgramToAllWorkshop>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwProgramToAllWorkshops");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.LessonName)
                    .HasMaxLength(50)
                    .HasColumnName("lesson_name");

                entity.Property(e => e.LessonSeq).HasColumnName("lesson_seq");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.WorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<VwProgramsAndNextLeadstartDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwProgramsAndNextLEADStartDate");

                entity.Property(e => e.LeadStartDate).HasColumnType("datetime");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<VwQualFundingMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwQual_Funding_Matrix");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.LocaleId).HasColumnName("locale_id");

                entity.Property(e => e.QualOrderId).HasColumnName("qual_order_id");

                entity.Property(e => e.QualStateFundingId).HasColumnName("qual_state_funding_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<VwQualFundingMatrixToParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwQualFundingMatrixToParticipant");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.LocaleId).HasColumnName("locale_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.QualOrderId).HasColumnName("qual_order_id");

                entity.Property(e => e.QualStateFundingId).HasColumnName("qual_state_funding_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("state_code");
            });

            modelBuilder.Entity<VwSecondaryQualToFunding>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSecondaryQualToFunding");

                entity.Property(e => e.AntaCourseCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.CombinedPending).HasColumnName("combined_pending");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.DualQualifications).HasColumnName("dual_qualifications");

                entity.Property(e => e.FederalFunding).HasColumnName("federal_funding");

                entity.Property(e => e.FundingType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("funding_type");

                entity.Property(e => e.FundingTypeAbbr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("funding_type_abbr");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualLevel).HasColumnName("qual_level");

                entity.Property(e => e.QualificationFlag)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qualification_flag");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.ReportTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("report_to");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwSecondaryQualificationsFundingMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSecondaryQualificationsFundingMatrix");

                entity.Property(e => e.AntaCourseCode)
                    .HasMaxLength(100)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.QualCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("qual_code");

                entity.Property(e => e.QualStateFundingId).HasColumnName("qual_state_funding_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<VwSmartSkilledWithQfm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSmartSkilledWithQFM");

                entity.Property(e => e.AntaCourseCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("anta_course_code");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FundingTypeAbbr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("funding_type_abbr");

                entity.Property(e => e.FundingTypeId).HasColumnName("funding_type_id");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.QualOrderId).HasColumnName("qual_order_id");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwTransferredParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTransferredParticipants");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.NewOverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("new_overview_date");

                entity.Property(e => e.NewProgramId).HasColumnName("new_program_id");

                entity.Property(e => e.OldOverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("old_overview_date");

                entity.Property(e => e.OldParticipantId).HasColumnName("old_participant_id");

                entity.Property(e => e.OldProgramId).HasColumnName("old_program_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ReportedAsWithdrawn).HasColumnName("reported_as_withdrawn");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TransFromParticipantId).HasColumnName("trans_from_participant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwTutorialssAttended>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTutorialssAttended");

                entity.Property(e => e.Attendance)
                    .HasColumnType("datetime")
                    .HasColumnName("attendance");

                entity.Property(e => e.Attended).HasColumnName("attended");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.TutorialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tutorial_date");

                entity.Property(e => e.WorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date");

                entity.Property(e => e.WorkshopId).HasColumnName("workshop_id");
            });

            modelBuilder.Entity<VwVettrakClientsA>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwVETtrak_ClientsA");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.EmployerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Employer_Name");

                entity.Property(e => e.Fax).HasMaxLength(4000);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GivenName)
                    .HasMaxLength(200)
                    .HasColumnName("Given_Name");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Home_Phone");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_Phone");

                entity.Property(e => e.OtherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Other_Name");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PoBoxAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PO_Box_address");

                entity.Property(e => e.PostalAddressNumber)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Postal_address_number");

                entity.Property(e => e.PostalBuildingAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Postal_building_address");

                entity.Property(e => e.PostalCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Postal_city");

                entity.Property(e => e.PostalPostcode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Postal_postcode")
                    .IsFixedLength(true);

                entity.Property(e => e.PostalState)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Postal_state");

                entity.Property(e => e.PostalStreetAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Postal_street_address");

                entity.Property(e => e.PostalSuburb)
                    .HasMaxLength(50)
                    .HasColumnName("postal_suburb");

                entity.Property(e => e.PostalUnitAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Postal_unit_address");

                entity.Property(e => e.PreferredName)
                    .HasMaxLength(50)
                    .HasColumnName("Preferred_Name");

                entity.Property(e => e.PrimaryAddressCity)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Primary_address_city");

                entity.Property(e => e.PrimaryAddressNumber)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Primary_address_number");

                entity.Property(e => e.PrimaryAddressPostcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Primary_address_postcode")
                    .IsFixedLength(true);

                entity.Property(e => e.PrimaryAddressState)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Primary_address_state");

                entity.Property(e => e.PrimaryBuildingAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Primary_building_address");

                entity.Property(e => e.PrimaryStreetAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Primary_street_address");

                entity.Property(e => e.PrimaryUnitAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Primary_unit_address");

                entity.Property(e => e.Surname).HasMaxLength(200);

                entity.Property(e => e.VettrakCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VETtrak_Code");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Work_Phone");
            });

            modelBuilder.Entity<VwVettrakClientsB>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwVETtrak_ClientsB");

                entity.Property(e => e.AtSchool)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("At_School");

                entity.Property(e => e.BirthTown)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("Birth_Town");

                entity.Property(e => e.CountryOfBirth).HasColumnName("Country_of_Birth");

                entity.Property(e => e.Disabilities)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HaveDisablity)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Have_Disablity");

                entity.Property(e => e.HavePriorEducation)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Have_Prior_Education");

                entity.Property(e => e.IndigenousStatus)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Indigenous_Status");

                entity.Property(e => e.LabourForceStatus).HasColumnName("Labour_force_status");

                entity.Property(e => e.LanguageSpokenAtHome).HasColumnName("Language_spoken_at_home");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PriorEducation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prior_Education");

                entity.Property(e => e.ProficiencyInSpokenEnglish)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Proficiency_in_spoken_English");

                entity.Property(e => e.SchoolLevel)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("School_Level")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Usi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USI");
            });

            modelBuilder.Entity<VwVicFunded2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwVicFunded2");

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(20)
                    .HasColumnName("course_code");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(100)
                    .HasColumnName("course_name");

                entity.Property(e => e.Expr1).HasMaxLength(50);

                entity.Property(e => e.Expr2).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.FmiUnitCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fmi_unit_code");

                entity.Property(e => e.FmiUnitDesc)
                    .HasMaxLength(1000)
                    .HasColumnName("fmi_unit_desc");

                entity.Property(e => e.FmiUnitId).HasColumnName("fmi_unit_id");

                entity.Property(e => e.FmiUnitTitle)
                    .HasMaxLength(100)
                    .HasColumnName("fmi_unit_title");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("location_name");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("middle_name");

                entity.Property(e => e.OverviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("overview_date");

                entity.Property(e => e.PartCompId).HasColumnName("part_comp_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_home");

                entity.Property(e => e.PhoneMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_mobile");

                entity.Property(e => e.PhoneWork)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_work");

                entity.Property(e => e.QualificationId).HasColumnName("qualification_id");

                entity.Property(e => e.UniqueStudentIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unique_student_identifier");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<VwrptAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwrpt_admin");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Course)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expr2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Licensee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Overview)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Participant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quals)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<VwrptFacilitatorRating>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwrpt_Facilitator_Ratings");

                entity.Property(e => e.Facilitator).HasMaxLength(101);
            });

            modelBuilder.Entity<WorkArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("work_area");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("display_name");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.NotesCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notes_company");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.WorkAreaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("work_area_id");

                entity.HasOne(d => d.Participant)
                    .WithMany()
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Refparticipantwa");
            });

            modelBuilder.Entity<Workbook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("workbook");

                entity.HasIndex(e => new { e.ReviewQuestionId, e.ParticipantId }, "PK35")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.LastEdited)
                    .HasColumnType("datetime")
                    .HasColumnName("last_edited")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.Response)
                    .HasMaxLength(2000)
                    .HasColumnName("response");

                entity.Property(e => e.ReviewQuestionId).HasColumnName("review_question_id");
            });

            modelBuilder.Entity<WorkflowEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("workflow_events");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventData)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("event_data");

                entity.Property(e => e.EventNameOrId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("event_name_or_id");

                entity.Property(e => e.EventStageId).HasColumnName("event_stage_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.WorkflowEventId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("workflow_event_id");

                entity.Property(e => e.WorkflowNameOrId)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("workflow_name_or_id");
            });

            modelBuilder.Entity<Workshop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("workshop");

                entity.HasIndex(e => e.WorkshopId, "PK6")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.ProgramId, e.LessonId }, "ak6")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Attendance)
                    .HasColumnType("datetime")
                    .HasColumnName("attendance");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.WorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date");

                entity.Property(e => e.WorkshopDuration)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("workshop_duration");

                entity.Property(e => e.WorkshopId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("workshop_id");
            });

            modelBuilder.Entity<WorkshopApproval>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.LessonId })
                    .HasName("PK6_1")
                    .IsClustered(false);

                entity.ToTable("workshop_approval");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.WorkshopDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workshop_date");

                entity.Property(e => e.WorkshopDuration)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("workshop_duration");
            });

            modelBuilder.Entity<Xml>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XML");

                entity.Property(e => e.Xml1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("xml")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ZtempPSoa2Verified>(entity =>
            {
                entity.HasKey(e => e.TempId)
                    .HasName("PK_temp_p_soa2_verified");

                entity.ToTable("ztemp_p_soa2_verified");

                entity.Property(e => e.TempId).HasColumnName("tempID");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.LessonQuestionId).HasColumnName("lesson_question_id");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");

                entity.Property(e => e.Verified).HasColumnName("verified");
            });

            modelBuilder.Entity<ZtempPSoa2Verifiedtotal>(entity =>
            {
                entity.HasKey(e => e.TempId)
                    .HasName("PK_temp_p_soa_2_verifiedtotal");

                entity.ToTable("ztemp_p_soa2_verifiedtotal");

                entity.Property(e => e.TempId).HasColumnName("tempID");

                entity.Property(e => e.MappingId).HasColumnName("mapping_id");

                entity.Property(e => e.ParticipantId).HasColumnName("participant_id");

                entity.Property(e => e.PerformanceCriteriaId).HasColumnName("performance_criteria_id");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.Verified).HasColumnName("verified");
            });

            modelBuilder.Entity<ZtempRpForPdpDia>(entity =>
            {
                entity.HasKey(e => new { e.LicenseeId, e.MmUserId, e.MmParticipantId });

                entity.ToTable("ztemp_rp_for_pdp_dias");

                entity.Property(e => e.LicenseeId).HasColumnName("licensee_id");

                entity.Property(e => e.MmUserId).HasColumnName("mm_user_id");

                entity.Property(e => e.MmParticipantId).HasColumnName("mm_participant_id");

                entity.Property(e => e.MmEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("mm_email");

                entity.Property(e => e.MmFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("mm_first_name");

                entity.Property(e => e.MmLastName)
                    .HasMaxLength(50)
                    .HasColumnName("mm_last_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
