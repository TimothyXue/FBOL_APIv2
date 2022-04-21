using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwFacilitatorsActiveBySurnameStateYear
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public int? OverViewYear { get; set; }
        public int? GradYear { get; set; }
        public string StateCode { get; set; }
    }
}
