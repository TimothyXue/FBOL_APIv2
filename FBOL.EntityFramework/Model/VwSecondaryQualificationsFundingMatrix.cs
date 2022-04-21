using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwSecondaryQualificationsFundingMatrix
    {
        public int QualificationId { get; set; }
        public string QualCode { get; set; }
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string AntaCourseCode { get; set; }
        public int? QualStateFundingId { get; set; }
        public int? StateId { get; set; }
        public int? FundingTypeId { get; set; }
        public string Version { get; set; }
    }
}
