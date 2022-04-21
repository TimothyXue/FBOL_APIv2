using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Hpa
    {
        public int HpaId { get; set; }
        public int? ParticipantId { get; set; }
        public string Hpa1 { get; set; }
        public bool Archived { get; set; }
        public DateTime? ArchivedDate { get; set; }
    }
}
