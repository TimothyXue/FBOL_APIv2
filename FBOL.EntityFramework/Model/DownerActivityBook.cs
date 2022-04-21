using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class DownerActivityBook
    {
        public int CourseId { get; set; }
        public short BookNumber { get; set; }
        public int ActivityId { get; set; }
    }
}
