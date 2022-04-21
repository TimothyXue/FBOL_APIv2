using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwTutorialssAttended
    {
        public DateTime? TutorialDate { get; set; }
        public int? ProgramId { get; set; }
        public DateTime? WorkshopDate { get; set; }
        public int ParticipantId { get; set; }
        public bool Attended { get; set; }
        public int WorkshopId { get; set; }
        public int LessonId { get; set; }
        public DateTime? Attendance { get; set; }
    }
}
