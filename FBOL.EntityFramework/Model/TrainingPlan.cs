using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class TrainingPlan
    {
        public int TpId { get; set; }
        public int? ParticipantId { get; set; }
        public bool? Fulltime { get; set; }
        public string Duration { get; set; }
        public DateTime? CommencementDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Position { get; set; }
        public string PartFullName { get; set; }
        public DateTime? PartAgree { get; set; }
        public DateTime? PartFirstAgree { get; set; }
        public string MmFullName { get; set; }
        public DateTime? MmAgree { get; set; }
        public DateTime? MmFirstAgree { get; set; }
        public string LmaRepFullName { get; set; }
        public DateTime? LmaRepAgree { get; set; }
        public DateTime? LmaRepFirstAgree { get; set; }
        public DateTime? MmContractCompleted { get; set; }
        public DateTime? PdfCreated { get; set; }
        public short? Version { get; set; }
        public DateTime? MmSignoff { get; set; }
        public DateTime? SignoffEmailSent { get; set; }
        public DateTime? NewTpRequired { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastEdited { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? PropCompletionDate { get; set; }
        public bool? ExcludeFromTpMissingEmail { get; set; }
    }
}
