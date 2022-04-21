using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwFmiUnitsByLessonId
    {
        public int CourseId { get; set; }
        public int FmiUnitId { get; set; }
        public int LessonId { get; set; }
    }
}
