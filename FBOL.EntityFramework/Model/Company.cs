using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Company
    {
        public int CompanyId { get; set; }
        public string Company1 { get; set; }
        public int? Quota { get; set; }
        public int SiteId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
        public int? CompanySize { get; set; }
        public string Industry { get; set; }
        public int CompanyHistoryId { get; set; }
        public string StatusCode { get; set; }
        public int? AccountManager { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public int? Presenter { get; set; }
        public DateTime? PresentationDate { get; set; }
        public string RegistrationTypeCode { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Comments { get; set; }
        public int? EnrolledCount { get; set; }
        public int? EnrolledCount12months { get; set; }
        public DateTime? MinimumExpiration { get; set; }
        public int LicenseId { get; set; }
        public string License { get; set; }
        public string FbolLogonId { get; set; }
    }
}
