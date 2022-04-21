using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Possible
    {
        public int ProgramId { get; set; }
        public int Quantity { get; set; }
        public int CatscanLicenseId { get; set; }
        public string Company { get; set; }
    }
}
