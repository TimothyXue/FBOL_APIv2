using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ZtempPSoa2Verifiedtotal
    {
        public long TempId { get; set; }
        public int? ParticipantId { get; set; }
        public int? PerformanceCriteriaId { get; set; }
        public int? MappingId { get; set; }
        public int? Total { get; set; }
        public int? Verified { get; set; }
    }
}
