using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingAdjustment
    {
        public int FundingAdjustmentId { get; set; }
        public int InvoiceRequestId { get; set; }
        public int UserId { get; set; }
        public int ParticipantId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Difference { get; set; }
        public string Comments { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
