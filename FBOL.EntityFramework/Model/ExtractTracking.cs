using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ExtractTracking
    {
        public int ExtractTrackingId { get; set; }
        public int ExtractHeaderId { get; set; }
        public DateTime InsertedDate { get; set; }
        public int ParticipantId { get; set; }
        public int? OtherId { get; set; }
        public string Tag { get; set; }
        public int? SubPartId { get; set; }
        public string PreviousValue { get; set; }
        public string NewValue { get; set; }
    }
}
