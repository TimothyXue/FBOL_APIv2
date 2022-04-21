using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Attendance
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
        public bool? CertGiven { get; set; }
        public DateTime? Created { get; set; }
    }
}
