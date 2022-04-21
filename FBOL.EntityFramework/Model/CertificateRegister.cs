using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CertificateRegister
    {
        public int CertificateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseCode { get; set; }
        public string LocationName { get; set; }
        public DateTime? OverviewDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public DateTime? CertificateIssued { get; set; }
    }
}
