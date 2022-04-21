using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ParticipantCompetencyFf
    {
        public int Id { get; set; }
        public int? ParticipantId { get; set; }
        public int? FmiUnitId { get; set; }
        public int? QualificationId { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
