using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantStartDatesFutureOnly
    {
        public DateTime? StartDate { get; set; }
        public int ParticipantId { get; set; }
    }
}
