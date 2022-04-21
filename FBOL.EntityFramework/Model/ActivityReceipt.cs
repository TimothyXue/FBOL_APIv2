using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActivityReceipt
    {
        public int ActivityReceiptId { get; set; }
        public int ActivityId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime? DateReceived { get; set; }
        public int? ReceivedByUserId { get; set; }
    }
}
