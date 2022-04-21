using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class GoalUser
    {
        public GoalUser()
        {
            ActionStepUsers = new HashSet<ActionStepUser>();
        }

        public int GoalId { get; set; }
        public int UserId { get; set; }
        public string GoalType { get; set; }
        public string Goal { get; set; }
        public DateTime? TargetDate { get; set; }
        public DateTime? AchievedDate { get; set; }
        public string Benefits { get; set; }
        public string Obstacles { get; set; }
        public string Solutions { get; set; }
        public string MeasurementOrig { get; set; }
        public string Measurement { get; set; }
        public bool? WorthIt { get; set; }
        public string Affirmation1 { get; set; }
        public string Affirmation2 { get; set; }
        public string Affirmation3 { get; set; }
        public string Affirmation4 { get; set; }
        public string Affirmation5 { get; set; }
        public string Affirmation6 { get; set; }
        public string Who { get; set; }
        public bool? Supportvalues { get; set; }
        public DateTime? Created { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ActionStepUser> ActionStepUsers { get; set; }
    }
}
