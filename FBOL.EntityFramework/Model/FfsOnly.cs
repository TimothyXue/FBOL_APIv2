using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FfsOnly
    {
        public int FmiUnitId { get; set; }
        public int CourseId { get; set; }
        public int MappingId { get; set; }
        public int FundingTypeId { get; set; }
    }
}
