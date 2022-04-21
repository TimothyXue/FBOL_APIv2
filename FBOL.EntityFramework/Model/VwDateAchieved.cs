using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwDateAchieved
    {
        public DateTime? DateAchieved { get; set; }
        public int ParticipantId { get; set; }
    }
}
