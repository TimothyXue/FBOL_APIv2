using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActivityIdChangeHistory
    {
        public int ActivityIdHistoryId { get; set; }
        public int PreviousCourseId { get; set; }
        public int NewCourseId { get; set; }
        public int PreviousActivityId { get; set; }
        public int NewActivityId { get; set; }
        public int PreviousAlVersion { get; set; }
        public int NewAlVersion { get; set; }
        public int PreviousFbolGuiVersionId { get; set; }
        public int NewFbolGuiVersionId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
