using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwActivityMatrixToElement
    {
        public int PerformanceCriteriaId { get; set; }
        public int ActivityId { get; set; }
        public int CourseId { get; set; }
        public short MappingId { get; set; }
        public int ElementId { get; set; }
        public int FmiUnitId { get; set; }
    }
}
