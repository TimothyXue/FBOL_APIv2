using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwPartCompByNumActiveAndCompletedUnit
    {
        public int ParticipantId { get; set; }
        public int? NumActiveAndCompletedUnits { get; set; }
    }
}
