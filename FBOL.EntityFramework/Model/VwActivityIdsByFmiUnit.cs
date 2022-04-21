using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwActivityIdsByFmiUnit
    {
        public int CourseId { get; set; }
        public short MappingId { get; set; }
        public int QualificationId { get; set; }
        public int FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public int ActivityId { get; set; }
        public string ActivityTitle { get; set; }
        public int? AlVersion { get; set; }
        public int? LessonDue { get; set; }
    }
}
