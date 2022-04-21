using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Branding
    {
        public int BrandingId { get; set; }
        public string Company { get; set; }
        public string Logo { get; set; }
        public string Banner { get; set; }
    }
}
