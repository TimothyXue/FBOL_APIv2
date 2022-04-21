using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwModule1AttendedOrDiscontinuedIsFalse
    {
        public int ParticipantId { get; set; }
        public bool? Attended { get; set; }
        public DateTime? TutorialDate { get; set; }
    }
}
