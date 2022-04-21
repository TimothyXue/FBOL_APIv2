using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LicenseeOld
    {
        public int LicenseeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Logon { get; set; }
        public int? UserId { get; set; }
    }
}
