using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingTypeCourse
    {
        public int FundingTypeCourseId { get; set; }
        public int CourseId { get; set; }
        public int FedFundingTypeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? QualificationIdIfDual { get; set; }
    }
}
