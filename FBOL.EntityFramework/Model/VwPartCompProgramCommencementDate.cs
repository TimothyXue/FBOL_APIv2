using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwPartCompProgramCommencementDate
    {
        public int ParticipantId { get; set; }
        public int ProgramId { get; set; }
        public DateTime? CommencementDate { get; set; }
    }
}
