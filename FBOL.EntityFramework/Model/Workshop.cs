using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Workshop
    {
        public int WorkshopId { get; set; }
        public int? ProgramId { get; set; }
        public DateTime? WorkshopDate { get; set; }
        public int LessonId { get; set; }
        public decimal? WorkshopDuration { get; set; }
        public DateTime? Attendance { get; set; }
    }
}
