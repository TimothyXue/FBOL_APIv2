using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class HideActivityByParticipant
    {
        public int ParticipantId { get; set; }
        public int ActivityId { get; set; }
    }
}
