using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Accomplishment
    {
        public int AccomplishmentId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime AccomplishmentDate { get; set; }
        public string Accomplishment1 { get; set; }
    }
}
