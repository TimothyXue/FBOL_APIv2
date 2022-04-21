using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingReceivedBackupForPeter
    {
        public long Id { get; set; }
        public int ClaimId { get; set; }
        public int? ParticipantId { get; set; }
        public int? ClaimHours { get; set; }
        public int? CappedHours { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RatePaid { get; set; }
        public decimal? RateExpected { get; set; }
        public int? FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public string StudentName { get; set; }
        public int? UserId { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public int? InvoiceRequestId { get; set; }
        public DateTime? LicenseePaidDate { get; set; }
        public int? QualificationId { get; set; }
        public string QualCode { get; set; }
        public decimal? LicenseeAmount { get; set; }
        public string SalesPerson { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
