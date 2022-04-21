using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class View1
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public short? MappingId { get; set; }
        public int? AlVersion { get; set; }
        public string Version { get; set; }
        public int ProgramId { get; set; }
        public int FmiUnitId { get; set; }
        public DateTime? EvidenceDate { get; set; }
        public int? FmiUnitIdNew { get; set; }
        public int ParticipantId { get; set; }
        public int PartCompId { get; set; }
        public int QualificationId { get; set; }
    }
}
