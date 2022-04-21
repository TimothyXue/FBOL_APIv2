using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FacilitatorInvoice
    {
        public int ProgramId { get; set; }
        public int ParticipantId { get; set; }
        public bool? M1 { get; set; }
        public bool? Mcr { get; set; }
        public bool? Resit { get; set; }
        public DateTime? Created { get; set; }
    }
}
