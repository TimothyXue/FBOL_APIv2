using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantByFirstActivityDate
    {
        public int ParticipantId { get; set; }
        public int LessonId { get; set; }
        public DateTime? EarliestActivityDate { get; set; }
    }
}
