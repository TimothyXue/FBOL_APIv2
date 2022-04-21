using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PositionDesc
    {
        public int PositionDescId { get; set; }
        public int? ParticipantId { get; set; }
        public string Field { get; set; }
        public string PositionDescType { get; set; }
        public string FieldValue { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
