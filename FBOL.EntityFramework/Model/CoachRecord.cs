using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CoachRecord
    {
        public int CoachRecordId { get; set; }
        public int ProgramId { get; set; }
        public int CoachUserId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime InitialDateEmailed { get; set; }
        public DateTime? CoachCallNumber1FirstTriedDate { get; set; }
        public DateTime? CoachCallNumber1SucceededDate { get; set; }
        public bool? ParticipantMetWithMm { get; set; }
        public bool? ParticipantDiscussedHpasWithMm { get; set; }
        public bool? ParticipantActionedHpas { get; set; }
        public bool? ParticipantDiscussedEvidenceFolioWithMm { get; set; }
        public bool? ParticipantCommencedTppandTpipactivities { get; set; }
        public bool? ParticipantActionedDelegation { get; set; }
        public bool? ParticipantCommencedBlockActions { get; set; }
        public bool? DiscussedProgramGoalWithParticipant { get; set; }
        public string Comments { get; set; }
        public DateTime? CoachCallNumber2FirstTriedDate { get; set; }
        public DateTime? CoachCallNumber2SucceededDate { get; set; }
        public bool? ProgressOnActionsMoreTimeOnHpas { get; set; }
        public string EvidencePortfolioStatus { get; set; }
        public string FirstTppandTpipactivitiesStatus { get; set; }
        public string DelegationStatus { get; set; }
        public string ActionBlock1Status { get; set; }
        public string ProgramGoalStatus { get; set; }
        public string BiggestAchievementSinceBlock1 { get; set; }
        public string IdeasToolsSuccessfullyAppliedSinceBlock1 { get; set; }
        public string Comments2 { get; set; }
        public DateTime? CoachCallNumber3FirstTriedDate { get; set; }
        public DateTime? CoachCallNumber3SucceededDate { get; set; }
        public bool? DiscussedActionsGoals { get; set; }
        public bool? ClarifiedBlock2AssignmentsAnsweredQuestions { get; set; }
        public bool? AskedParticipantAboutFeedbackGiven { get; set; }
        public bool? TandDplanUnderway { get; set; }
        public bool? FirstTppandTpipactivitiesStatus2 { get; set; }
        public bool? ComplaintsRecordObtained { get; set; }
        public DateTime? CoachCallNumber4FirstTriedDate { get; set; }
        public DateTime? CoachCallNumber4SucceededDate { get; set; }
        public bool? AskedParticipantAboutFeedbackGivenCall4 { get; set; }
        public bool? TandDplanUnderwayCall4 { get; set; }
        public bool? FirstTppandTpipactivitiesStatusCall4 { get; set; }
        public bool? ComplaintsRecordObtainedCall4 { get; set; }
        public DateTime? CoachCallNumber5FirstTriedDate { get; set; }
        public DateTime? CoachCallNumber5SucceededDate { get; set; }
        public bool? ClarifiedBlock3AssignmentsAnsweredQuestions { get; set; }
        public bool? DiscussedActionsGoalsCall5 { get; set; }
        public string SecondTppandTpipactivitiesStatus { get; set; }
        public string ThirdPartyReportSoughtFromMm { get; set; }
        public DateTime? SubmittedYellowBookletBlock1 { get; set; }
        public DateTime? SubmittedYellowBookletBlock2 { get; set; }
        public DateTime? SubmittedYellowBookletBlock3 { get; set; }
    }
}
