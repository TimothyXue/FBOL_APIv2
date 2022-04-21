using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class QualHour
    {
        public int QualHoursId { get; set; }
        public int QualificationId { get; set; }
        public int? CourseId { get; set; }
        public bool? DualQual { get; set; }
        public decimal Push { get; set; }
        public string DualQualDorS { get; set; }
    }
}
