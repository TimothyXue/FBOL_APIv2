using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingType
    {
        public short FundingTypeId { get; set; }
        public string FundingType1 { get; set; }
        public string FundingTypeAbbr { get; set; }
        public string ReportTo { get; set; }
        public bool? Archived { get; set; }
        public bool? CombinedPending { get; set; }
        public bool? DualQualifications { get; set; }
    }
}
