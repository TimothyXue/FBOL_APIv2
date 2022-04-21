using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Tool
    {
        public int ToolId { get; set; }
        public int ParticipantId { get; set; }
        public string ToolType { get; set; }
        public string Field { get; set; }
        public string ToolValue { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? DateArchived { get; set; }
        public Guid? ArchivedId { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
