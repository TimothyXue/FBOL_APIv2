using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class TrainingPlanTemp
    {
        public int ParticipantId { get; set; }
        public DateTime? PartAgree { get; set; }
        public DateTime? MmAgree { get; set; }
        public DateTime? LmaRepAgree { get; set; }
    }
}
