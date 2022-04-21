using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingReceivedBackup
    {
        public int ClaimId { get; set; }
        public int? ParticipantId { get; set; }
        public int? ClaimHours { get; set; }
        public double? Amount { get; set; }
        public string FmiUnitCode { get; set; }
        public string StudentName { get; set; }
        public int? UserId { get; set; }
        public string ReferenceNo { get; set; }
        public string ProcessedDate { get; set; }
        public int? InvoiceRequestId { get; set; }
        public double? CalculatedLicenseeAmount { get; set; }
        public DateTime? LicenseePaidDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? LicenseeAmount { get; set; }
    }
}
