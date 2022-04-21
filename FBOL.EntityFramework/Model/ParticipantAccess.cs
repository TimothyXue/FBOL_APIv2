using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ParticipantAccess
    {
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public DateTime Access { get; set; }

        public virtual Participant Participant { get; set; }
        public virtual User User { get; set; }
    }
}
