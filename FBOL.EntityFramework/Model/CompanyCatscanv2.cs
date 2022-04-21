using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CompanyCatscanv2
    {
        public int CompanyHistoryId { get; set; }
        public int CompanyId { get; set; }
        public string Company { get; set; }
        public int SiteId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public int? CompanySize { get; set; }
        public string StatusCode { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? EnrolledCount { get; set; }
        public string RegistrationTypeCode { get; set; }
        public int LicenseeId { get; set; }
        public string Licensee { get; set; }
        public string Presenter { get; set; }
        public string AccountManager { get; set; }
        public string Industry { get; set; }
    }
}
