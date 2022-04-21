using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingRatesBackup
    {
        public DateTime StartDate { get; set; }
        public double CourseId { get; set; }
        public double? ClientUpfront { get; set; }
        public double? ClientUpfrontPp { get; set; }
        public double? TotalFunding { get; set; }
        public double? LicenseeUpfront { get; set; }
        public double? LicenseeUpfrontPp { get; set; }
        public double? LicenseeFunding { get; set; }
        public double? LicenseeFundingPp { get; set; }
        public double? LicenseeFundingAddL2 { get; set; }
        public double? LicenseeFundingAddL3 { get; set; }
        public int? SspTuitionFee { get; set; }
        public string VtgTuitionFeeHour { get; set; }
        public string CoursePart { get; set; }
    }
}
