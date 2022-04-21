using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantStatusChangeLatest
    {
        public int StatusId { get; set; }
        public int ParticipantId { get; set; }
        public int OldProgramId { get; set; }
        public int NewProgramId { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? Reported { get; set; }
        public bool? ReportedAsWithdrawn { get; set; }
    }
}
