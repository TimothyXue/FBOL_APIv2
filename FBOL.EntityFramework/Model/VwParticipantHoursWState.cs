using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantHoursWState
    {
        public int ProgramId { get; set; }
        public int ParticipantId { get; set; }
        public int FmiUnitId { get; set; }
        public int QualificationId { get; set; }
        public string StateCode { get; set; }
        public short? NominalHours { get; set; }
    }
}
