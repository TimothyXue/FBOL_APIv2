using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwAttendedOrHadTutorial
    {
        public int WorkshopId { get; set; }
        public int ParticipantId { get; set; }
        public bool Attended { get; set; }
        public string ReasonCode { get; set; }
        public bool? MmAttended { get; set; }
        public bool? CoachAttended { get; set; }
        public int? TutorialWith { get; set; }
        public DateTime? TutorialDate { get; set; }
        public int? AttendanceWorkshopId { get; set; }
        public DateTime? WorkshopDate { get; set; }
        public int LessonId { get; set; }
        public int? ProgramId { get; set; }
        public DateTime? DateAtt { get; set; }
    }
}
