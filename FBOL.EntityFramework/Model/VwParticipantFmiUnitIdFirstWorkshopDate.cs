using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantFmiUnitIdFirstWorkshopDate
    {
        public int ParticipantId { get; set; }
        public int FmiUnitId { get; set; }
        public DateTime? FirstWorkshop { get; set; }
    }
}
