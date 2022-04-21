using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EfTemp
    {
        public int? ParticipantId { get; set; }
        public DateTime? Reported { get; set; }
        public DateTime? McrReported { get; set; }
        public DateTime? CertReported { get; set; }
        public DateTime? CompReported { get; set; }
    }
}
