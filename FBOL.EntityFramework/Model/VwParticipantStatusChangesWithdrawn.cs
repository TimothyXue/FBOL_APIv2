using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantStatusChangesWithdrawn
    {
        public int ParticipantId { get; set; }
        public DateTime? WithdrawnDate { get; set; }
    }
}
