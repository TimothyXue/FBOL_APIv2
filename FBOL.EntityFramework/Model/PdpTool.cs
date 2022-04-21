using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PdpTool
    {
        public int Id { get; set; }
        public int? ParticipantId { get; set; }
        public int? ActivityId { get; set; }
    }
}
