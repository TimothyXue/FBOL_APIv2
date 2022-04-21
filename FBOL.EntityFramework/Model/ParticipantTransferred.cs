using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ParticipantTransferred
    {
        public int ParticipantId { get; set; }
        public int ProgramId { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Report { get; set; }
    }
}
