using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwFmiUnitToActivitiesByCourseId
    {
        public int PerformanceCriteriaId { get; set; }
        public int ActivityId { get; set; }
        public int CourseId { get; set; }
        public short MappingId { get; set; }
        public int ElementId { get; set; }
        public int FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public string FmiUnitTitle { get; set; }
        public string ElementTitle { get; set; }
        public string PerformanceCriteriaDesc { get; set; }
        public string ActivityTitle { get; set; }
    }
}
