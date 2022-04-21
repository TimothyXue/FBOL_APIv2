using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingReceived
    {
        public long FundingReceivedId { get; set; }
        public int? ParticipantId { get; set; }
        public int? UserId { get; set; }
        public int? FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public int? ClaimHours { get; set; }
        public int? CappedHours { get; set; }
        public DateTime? PaymentMonth { get; set; }
        public int? QualificationId { get; set; }
        public string QualCode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RatePaid { get; set; }
        public decimal? RateExpected { get; set; }
        public DateTime? RateVerified { get; set; }
        public decimal? LicenseeAmount { get; set; }
        public int? InvoiceRequestId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
