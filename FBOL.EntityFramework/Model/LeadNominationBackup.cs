using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LeadNominationBackup
    {
        public int? ParticipantId { get; set; }
        public Guid? SubscriptionId { get; set; }
        public string NominationType { get; set; }
    }
}
