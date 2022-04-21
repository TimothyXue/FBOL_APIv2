using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PartCourse
    {
        public short CourseId { get; set; }
        public string CoursePart { get; set; }
        public string AntaCourseCode { get; set; }
    }
}
