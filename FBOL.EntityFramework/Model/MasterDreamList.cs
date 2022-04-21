using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class MasterDreamList
    {
        public int MasterDreamListId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime? DreamDate { get; set; }
        public string Item { get; set; }
        public string AreaOfLife { get; set; }
        public DateTime? Achieved { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
