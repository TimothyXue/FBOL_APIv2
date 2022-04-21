using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwFirstCompetencyAchievedByParticipantId
    {
        public int ParticipantId { get; set; }
        public DateTime? FirstAchievedDate { get; set; }
    }
}
