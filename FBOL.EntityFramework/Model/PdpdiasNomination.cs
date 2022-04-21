using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PdpdiasNomination
    {
        public int NomId { get; set; }
        public int ParticipantId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime Created { get; set; }
    }
}
