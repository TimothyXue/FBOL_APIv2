using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LessonEmail
    {
        public int LessonEmailId { get; set; }
        public int? LessonId { get; set; }
        public int? Duration { get; set; }
        public string Body { get; set; }
        public string Attachment { get; set; }
        public string Subject { get; set; }
        public bool? Html { get; set; }
        public bool? SenderFacilitator { get; set; }
        public bool? ToParticipant { get; set; }
        public bool? ToMm { get; set; }
        public bool? ToCoach { get; set; }
        public bool? ToFacilitator { get; set; }
        public string CoursePart { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
