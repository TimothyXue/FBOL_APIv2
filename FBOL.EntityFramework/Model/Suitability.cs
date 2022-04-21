using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Suitability
    {
        public int ParticipantId { get; set; }
        public string Position { get; set; }
        public string Goals { get; set; }
        public string Achieve { get; set; }
        public string UseComputer { get; set; }
        public string InternetAccess { get; set; }
        public string OtherInterests { get; set; }
        public bool? Completed { get; set; }
        public short? Suitable { get; set; }
        public string Comments { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
