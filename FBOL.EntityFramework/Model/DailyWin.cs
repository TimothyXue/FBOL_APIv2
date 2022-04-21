using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class DailyWin
    {
        public int DailyWinsId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime? WinDate { get; set; }
        public string Personal1 { get; set; }
        public string Personal2 { get; set; }
        public string Personal3 { get; set; }
        public string Personal4 { get; set; }
        public string Personal5 { get; set; }
        public string Business1 { get; set; }
        public string Business2 { get; set; }
        public string Business3 { get; set; }
        public string Business4 { get; set; }
        public string Business5 { get; set; }
        public string WinsToday { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
