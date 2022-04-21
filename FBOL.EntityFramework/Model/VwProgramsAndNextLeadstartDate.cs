using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwProgramsAndNextLeadstartDate
    {
        public int ProgramId { get; set; }
        public DateTime? OverviewDate { get; set; }
        public DateTime? LeadStartDate { get; set; }
    }
}
