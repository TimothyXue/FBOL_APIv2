using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ScheduledHour
    {
        public int ScheduledHoursId { get; set; }
        public int? CourseId { get; set; }
        public int FmiUnitId { get; set; }
        public decimal ScheduledHours { get; set; }
        public DateTime ActiveFrom { get; set; }
        public string StateCode { get; set; }
    }
}
