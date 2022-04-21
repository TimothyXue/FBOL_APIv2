using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FmiUnit
    {
        public FmiUnit()
        {
            CourseCompetencies = new HashSet<CourseCompetency>();
            Elements = new HashSet<Element>();
            FmiMatrices = new HashSet<FmiMatrix>();
            OnlineModules = new HashSet<OnlineModule>();
        }

        public int FmiUnitId { get; set; }
        public string FmiUnitCode { get; set; }
        public string FmiUnitTitle { get; set; }
        public string FmiUnitDesc { get; set; }
        public DateTime? InsertDate { get; set; }

        public virtual ICollection<CourseCompetency> CourseCompetencies { get; set; }
        public virtual ICollection<Element> Elements { get; set; }
        public virtual ICollection<FmiMatrix> FmiMatrices { get; set; }
        public virtual ICollection<OnlineModule> OnlineModules { get; set; }
    }
}
