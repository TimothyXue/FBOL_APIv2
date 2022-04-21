using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Lead2005list
    {
        public string Company { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Licensee { get; set; }
        public string State { get; set; }
        public int? Groups { get; set; }
    }
}
