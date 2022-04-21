using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CourseMapping
    {
        public int MappingLockedId { get; set; }
        public int CourseId { get; set; }
        public int MappingId { get; set; }
        public bool Locked { get; set; }
        public DateTime? OverviewDate { get; set; }
        public DateTime? Created { get; set; }
    }
}
