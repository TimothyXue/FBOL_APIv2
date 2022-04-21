using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwHouseKeepingNoPhone
    {
        public int? UserId { get; set; }
        public int? ParticipantId { get; set; }
        public short? FundingTypeId { get; set; }
        public DateTime? WelcomeEmailDate { get; set; }
        public string Company { get; set; }
        public string HomeState { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalState { get; set; }
        public string CompanyState { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneMobile { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool? Discontinued { get; set; }
    }
}
