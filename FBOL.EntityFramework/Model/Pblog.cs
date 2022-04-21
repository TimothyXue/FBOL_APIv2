using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Pblog
    {
        public DateTime Date { get; set; }
        public string Table { get; set; }
        public string Column { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public int? ParticipantId { get; set; }
    }
}
