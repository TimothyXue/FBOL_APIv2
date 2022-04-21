using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EbookCourseMaterial
    {
        public int EbookCourseMaterialId { get; set; }
        public string EbookCourseMaterialDesc { get; set; }
        public int CourseId { get; set; }
        public string EbookUrn { get; set; }
        public int? ExpiryDays { get; set; }
        public bool AllowPrinting { get; set; }
    }
}
