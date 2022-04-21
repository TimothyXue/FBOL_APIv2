using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PlanOfAction
    {
        public int PlanOfActionId { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public string PoaDesc { get; set; }
        public string Url { get; set; }
    }
}
