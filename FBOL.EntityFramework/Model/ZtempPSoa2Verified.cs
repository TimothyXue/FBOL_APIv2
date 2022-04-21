using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ZtempPSoa2Verified
    {
        public long TempId { get; set; }
        public int? ParticipantId { get; set; }
        public int? ActivityId { get; set; }
        public int? PerformanceCriteriaId { get; set; }
        public int? MappingId { get; set; }
        public bool? Verified { get; set; }
        public int? LessonQuestionId { get; set; }
    }
}
