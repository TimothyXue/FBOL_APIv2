using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ExtractExclude
    {
        public int ExtractExcludeId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime ExcludeUntilDate { get; set; }
    }
}
