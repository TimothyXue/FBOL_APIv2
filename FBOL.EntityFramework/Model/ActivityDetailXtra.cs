using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActivityDetailXtra
    {
        public int ActivityDetailId { get; set; }
        public bool? CompletedOk { get; set; }
        public DateTime? FirstCompleted { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
