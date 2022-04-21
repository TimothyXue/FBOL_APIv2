using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PcsReported
    {
        public int RecId { get; set; }
        public int? P { get; set; }
        public int? Pc { get; set; }
        public int? Fmi { get; set; }
        public DateTime? D { get; set; }
    }
}
