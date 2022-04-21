using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LicenseeAccess
    {
        public int LicenseeId { get; set; }
        public int AccessLicenseeId { get; set; }

        public virtual User AccessLicensee { get; set; }
        public virtual User Licensee { get; set; }
    }
}
