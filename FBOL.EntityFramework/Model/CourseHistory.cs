using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CourseHistory
    {
        public int CourseHistoryId { get; set; }
        public string CourseCode { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public string Action { get; set; }
        public DateTime? ActionDate { get; set; }
        public string StateCode { get; set; }
    }
}
