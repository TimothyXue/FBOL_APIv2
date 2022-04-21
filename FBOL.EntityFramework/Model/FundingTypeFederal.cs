using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingTypeFederal
    {
        public int FedFundingTypeId { get; set; }
        public string FedFundingType { get; set; }
        public string FedFundingTypeAbbr { get; set; }
        public bool? DualQualifications { get; set; }
    }
}
