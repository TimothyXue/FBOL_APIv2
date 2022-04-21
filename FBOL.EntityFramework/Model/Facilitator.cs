using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Facilitator
    {
        public int Id { get; set; }
        public int? FacId { get; set; }
        public int? FacLevel { get; set; }
        public bool? Deleted { get; set; }
    }
}
