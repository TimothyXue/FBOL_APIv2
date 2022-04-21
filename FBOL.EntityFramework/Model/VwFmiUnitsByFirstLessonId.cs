using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwFmiUnitsByFirstLessonId
    {
        public int CourseId { get; set; }
        public int FmiUnitId { get; set; }
        public int? FirstLessonId { get; set; }
        public int QualificationId { get; set; }
        public int AlVersion { get; set; }
        public short MappingId { get; set; }
    }
}
