using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FmiReplacement
    {
        public int FmiUnitId { get; set; }
        public int OldFmiUnitId { get; set; }
        public bool SameMapping { get; set; }
    }
}
