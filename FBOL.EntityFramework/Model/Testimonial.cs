using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Testimonial
    {
        public string State { get; set; }
        public string Course { get; set; }
        public DateTime? OverviewDate { get; set; }
        public string CourseLocation { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Feedback { get; set; }
    }
}
