using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwCompetencyCompletedDateByParticipantId
    {
        public int? ParticipantId { get; set; }
        public DateTime? CompetencyCompleted { get; set; }
    }
}
