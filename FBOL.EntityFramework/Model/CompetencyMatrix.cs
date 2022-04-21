using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CompetencyMatrix
    {
        public int FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public string FmiUnitTitle { get; set; }
        public string FmiUnitDesc { get; set; }
        public int ElementId { get; set; }
        public string ElementTitle { get; set; }
        public string ElementRef { get; set; }
        public string ElementRange { get; set; }
        public int PerformanceCriteriaId { get; set; }
        public string PerformanceCriteriaDesc { get; set; }
        public string PerformanceCriteriaRef { get; set; }
        public string PerformanceCriteriaRange { get; set; }
    }
}
