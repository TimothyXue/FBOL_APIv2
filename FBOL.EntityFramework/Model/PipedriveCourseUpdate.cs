using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PipedriveCourseUpdate
    {
        public int PipedriveId { get; set; }
        public string LastCourse { get; set; }
        public string Overview { get; set; }
        public string Graduation { get; set; }
        public string Mm { get; set; }
        public string Coach { get; set; }
        public string PastCourses { get; set; }
    }
}
