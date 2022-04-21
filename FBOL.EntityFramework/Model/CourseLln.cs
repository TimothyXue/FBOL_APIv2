using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CourseLln
    {
        public int CourseLlnId { get; set; }
        public int CourseId { get; set; }
        public int LlnId { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
