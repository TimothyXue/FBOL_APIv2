using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class WorkshopApproval
    {
        public int ProgramId { get; set; }
        public int LessonId { get; set; }
        public DateTime? WorkshopDate { get; set; }
        public decimal? WorkshopDuration { get; set; }
    }
}
