using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class WorkArea
    {
        public int WorkAreaId { get; set; }
        public int ParticipantId { get; set; }
        public int? ActivityId { get; set; }
        public string Url { get; set; }
        public string DisplayName { get; set; }
        public string NotesCompany { get; set; }
        public string Notes { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
