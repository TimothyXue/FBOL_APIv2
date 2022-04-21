using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CourseFeePeriod
    {
        public int CourseFeePeriodId { get; set; }
        public int CourseId { get; set; }
        public int? FundingTypeId { get; set; }
        public int? QualificationId { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal? TuitionFee { get; set; }
        public decimal? ResourceFee { get; set; }
        public string StateCode { get; set; }
        public decimal? Push { get; set; }
        public decimal? GovtContribution { get; set; }
        public DateTime ActiveDate { get; set; }
    }
}
