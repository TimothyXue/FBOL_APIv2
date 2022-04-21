using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwFfsonlyWip
    {
        public int UserId { get; set; }
        public int ParticipantId { get; set; }
        public int? ProgramId { get; set; }
        public int ParticipantCompetencyFmiUnitId { get; set; }
        public int? FmiUnitId { get; set; }
        public int? FfsOnlyFmiUnitId { get; set; }
        public int? SfscId { get; set; }
        public int? CourseId { get; set; }
        public int? FfsOnlyCourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string AntaCourseCode { get; set; }
    }
}
