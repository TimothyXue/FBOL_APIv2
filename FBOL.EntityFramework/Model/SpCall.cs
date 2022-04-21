using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class SpCall
    {
        public int SpCallId { get; set; }
        public string SpName { get; set; }
        public string SpParams { get; set; }
        public DateTime DateTime { get; set; }
    }
}
