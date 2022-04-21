using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ExtractHeader
    {
        public int ExtractHeaderId { get; set; }
        public int ExtractTypeId { get; set; }
        public DateTime ExtractStart { get; set; }
        public DateTime? GetDateUsed { get; set; }
    }
}
