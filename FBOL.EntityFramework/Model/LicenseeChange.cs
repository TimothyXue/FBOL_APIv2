using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LicenseeChange
    {
        public int ParticipantId { get; set; }
        public int PreviousLicenseeId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
