using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Licensee
    {
        public int CatscanMasterLicenseeId { get; set; }
        public string CourseScheduleLine1 { get; set; }
        public string CourseScheduleLine2 { get; set; }
        public string CourseScheduleLine3 { get; set; }
        public string CourseScheduleLine4 { get; set; }
        public string Contact { get; set; }
        public string ContactNumber { get; set; }
    }
}
