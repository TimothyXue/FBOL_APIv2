using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingImport
    {
        public int FundingImportId { get; set; }
        public string FmiUnitCode { get; set; }
        public int ClaimHours { get; set; }
        public DateTime PaymentMonth { get; set; }
        public int UserId { get; set; }
        public string QualCode { get; set; }
        public decimal Amount { get; set; }
    }
}
