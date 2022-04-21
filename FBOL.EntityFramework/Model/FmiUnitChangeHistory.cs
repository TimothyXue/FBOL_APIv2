using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FmiUnitChangeHistory
    {
        public int FmiUnitUid { get; set; }
        public int FmiUnitId { get; set; }
        public int FmiUnitIdNew { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
