using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FmiMatrix
    {
        public int LessonId { get; set; }
        public int FmiUnitId { get; set; }

        public virtual FmiUnit FmiUnit { get; set; }
    }
}
