using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingRate
    {
        public DateTime StartDate { get; set; }
        public bool StartOnCcDate { get; set; }
        public int QualificationId { get; set; }
        public decimal Rate { get; set; }
        public decimal RplMultiplier { get; set; }
        public decimal RegionalRate { get; set; }
        public int MaxHours { get; set; }
        public int? SspTuitionFee { get; set; }
        public string VtgTuitionFeeHour { get; set; }
    }
}
