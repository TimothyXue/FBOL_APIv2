using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CourseCompetency
    {
        public int CourseId { get; set; }
        public int FmiUnitId { get; set; }
        public string CoursePart { get; set; }
        public short MappingId { get; set; }
        public bool? ForRpl { get; set; }
        public int QualificationId { get; set; }
        public string FmiUnitRef { get; set; }
        public DateTime? WhenAdded { get; set; }

        public virtual FmiUnit FmiUnit { get; set; }
    }
}
