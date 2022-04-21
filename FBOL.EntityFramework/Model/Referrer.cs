using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Referrer
    {
        public int ReferrerId { get; set; }
        public int UserId { get; set; }
        public bool? Deleted { get; set; }
        public int? ReportToStateId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
