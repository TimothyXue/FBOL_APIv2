using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwMostRecentParticipantHavingNonNullAdressByUserId
    {
        public int? ParticipantId { get; set; }
        public int UserId { get; set; }
    }
}
