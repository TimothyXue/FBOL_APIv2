using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwTransferredParticipant
    {
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OldProgramId { get; set; }
        public DateTime? OldOverviewDate { get; set; }
        public string Status { get; set; }
        public int ParticipantId { get; set; }
        public int TransFromParticipantId { get; set; }
        public int? NewProgramId { get; set; }
        public DateTime? NewOverviewDate { get; set; }
        public int? OldParticipantId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ReportedAsWithdrawn { get; set; }
    }
}
