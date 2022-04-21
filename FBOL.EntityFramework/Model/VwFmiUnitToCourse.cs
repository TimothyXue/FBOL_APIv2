using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwFmiUnitToCourse
    {
        public int CourseId { get; set; }
        public int ProgramId { get; set; }
        public short MappingId { get; set; }
        public int FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public int? FmiUnitIdUpgradedFrom { get; set; }
    }
}
