using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActivityDetailSnapshot
    {
        public int AdsId { get; set; }
        public int ActivityDetailId { get; set; }
        public DateTime SnapshotDate { get; set; }
        public string XmlActivityData { get; set; }
    }
}
