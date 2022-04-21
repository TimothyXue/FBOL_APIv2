using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwMinEvidenceDateByParticipantId
    {
        public int ParticipantId { get; set; }
        public DateTime? MinEviidenceDate { get; set; }
    }
}
