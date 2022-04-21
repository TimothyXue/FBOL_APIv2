using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class TestActDump
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string CourseCode { get; set; }
        public DateTime? OverviewDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public DateTime? CertificateIssued { get; set; }
        public bool InHouse { get; set; }
        public string Coach { get; set; }
        public string Managermentor { get; set; }
        public string AccountType { get; set; }
        public string AmountPaid { get; set; }
        public int? CatscanId { get; set; }
    }
}
