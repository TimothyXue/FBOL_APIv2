using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Funding
    {
        public int ParticipantId { get; set; }
        public DateTime? ReferralForm { get; set; }
        public DateTime? CourseDetailsForm { get; set; }
        public DateTime? TrainingPlan { get; set; }
        public DateTime? InvoiceIssued { get; set; }
        public double? ClientAmount { get; set; }
        public int? InvoiceNo { get; set; }
        public DateTime? ClientPaid { get; set; }
        public DateTime? StockDispatched { get; set; }
        public double? LicenseeUpfrontAmount { get; set; }
        public DateTime? LicenseeUpfrontPaid { get; set; }
        public int? InvoiceRequestId { get; set; }
        public double? TotalFunding { get; set; }
        public double? LicenseeFundingAmount { get; set; }
        public DateTime? CreateDate { get; set; }
        public short? PurchaseLevel { get; set; }
    }
}
