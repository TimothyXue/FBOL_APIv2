using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Feedback
    {
        public int WorkshopId { get; set; }
        public int ParticipantId { get; set; }
        public string ContractScore { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public bool LearningOutcomeMet { get; set; }
    }
}
