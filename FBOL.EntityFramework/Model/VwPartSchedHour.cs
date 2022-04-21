using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwPartSchedHour
    {
        public int ParticipantId { get; set; }
        public decimal? SumScheduleHours { get; set; }
    }
}
