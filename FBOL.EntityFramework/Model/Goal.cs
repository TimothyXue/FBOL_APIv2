using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Goal
    {
        public int GoalId { get; set; }
        public int ParticipantId { get; set; }
        public string GoalOrig { get; set; }
        public string Goal1 { get; set; }
        public DateTime? TargetDate { get; set; }
        public DateTime? AchievedDate { get; set; }
        public string Benefits { get; set; }
        public string Obstacles { get; set; }
        public string Solutions { get; set; }
        public string MeasurementOrig { get; set; }
        public string Measurement { get; set; }
        public byte? IsWpp { get; set; }
        public string GoalType { get; set; }
        public bool? WorthIt { get; set; }
        public string Affirmation1 { get; set; }
        public string Affirmation2 { get; set; }
        public string Affirmation3 { get; set; }
        public string Affirmation4 { get; set; }
        public string Affirmation5 { get; set; }
        public string Affirmation6 { get; set; }
        public string Who { get; set; }
        public bool? Supportvalues { get; set; }
        public int? UserId { get; set; }
        public string AreaOfLife { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? DateArchived { get; set; }
        public bool? Saved { get; set; }
        public string ExpectedSavings { get; set; }
        public string ReportProgressTo { get; set; }
        public string OthersToNotify { get; set; }
        public string AdditionalResources { get; set; }
    }
}
