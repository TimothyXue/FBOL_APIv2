using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ZtempRpForPdpDia
    {
        public int LicenseeId { get; set; }
        public int MmUserId { get; set; }
        public int MmParticipantId { get; set; }
        public string MmFirstName { get; set; }
        public string MmLastName { get; set; }
        public string MmEmail { get; set; }
    }
}
