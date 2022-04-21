using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FeedbackQuestionResponse
    {
        public int WorkshopId { get; set; }
        public int ParticipantId { get; set; }
        public int LessonQuestionId { get; set; }
        public bool Completed { get; set; }
        public string Response { get; set; }
        public DateTime? LastEdited { get; set; }
        public bool? Verified { get; set; }
    }
}
