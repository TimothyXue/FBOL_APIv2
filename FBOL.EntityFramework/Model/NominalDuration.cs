using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class NominalDuration
    {
        public int CourseId { get; set; }
        public string StateCode { get; set; }
        public short DurationMonths { get; set; }
        public DateTime StartDate { get; set; }
    }
}
