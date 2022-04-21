using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwPartCompFirstStartDateByPartId
    {
        public int ParticipantId { get; set; }
        public DateTime? MinStartDate { get; set; }
    }
}
