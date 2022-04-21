using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantCompetencyAttendedOrTuteDatePresentLast4Month
    {
        public int PartCompId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? WorkshopDate { get; set; }
        public DateTime? TutorialDate { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
