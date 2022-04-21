using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwPartSchedHoursByUnit
    {
        public int ParticipantId { get; set; }
        public int FmiUnitId { get; set; }
        public decimal? Numhours { get; set; }
    }
}
