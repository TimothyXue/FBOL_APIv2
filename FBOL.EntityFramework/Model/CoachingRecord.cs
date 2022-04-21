using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CoachingRecord
    {
        public int CoachRecordId { get; set; }
        public int ParticipantId { get; set; }
        public int CallNo { get; set; }
        public DateTime? DateAttempted { get; set; }
        public DateTime? DateContacted { get; set; }
        public string ActionsAssessmentsDiscussed { get; set; }
        public string CommentsWinsSuccesses { get; set; }
    }
}
