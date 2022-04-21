using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PowerThought
    {
        public int PtId { get; set; }
        public string PtText { get; set; }
        public string PtAuthor { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
