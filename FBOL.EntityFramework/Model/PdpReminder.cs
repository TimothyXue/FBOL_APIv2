using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PdpReminder
    {
        public int ReminderId { get; set; }
        public int? ParticipantId { get; set; }
        public bool? ToParticipant { get; set; }
        public bool? ToMm { get; set; }
        public bool? ToCoach { get; set; }
        public bool? Ii { get; set; }
        public string IiFreq { get; set; }
        public bool? D7 { get; set; }
        public string D7Freq { get; set; }
        public bool? Qww { get; set; }
        public bool? QwwSteps { get; set; }
        public bool? Wpp { get; set; }
        public bool? WppSteps { get; set; }
        public bool? Dw { get; set; }
        public string DwFreq { get; set; }
        public bool? Ml { get; set; }
        public string MlFreq { get; set; }
        public bool? PGoal { get; set; }
        public bool? PGoalSteps { get; set; }
    }
}
