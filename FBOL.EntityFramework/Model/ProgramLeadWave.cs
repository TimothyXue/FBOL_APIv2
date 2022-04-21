using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ProgramLeadWave
    {
        public int LeadWaveId { get; set; }
        public DateTime? MinWorkshopDate { get; set; }
        public int? Wave { get; set; }
    }
}
