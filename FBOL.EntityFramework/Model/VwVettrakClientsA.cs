using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwVettrakClientsA
    {
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string PreferredName { get; set; }
        public string VettrakCode { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string EmployerName { get; set; }
        public string Email { get; set; }
        public string PrimaryUnitAddress { get; set; }
        public string PrimaryBuildingAddress { get; set; }
        public string PrimaryAddressNumber { get; set; }
        public string PrimaryStreetAddress { get; set; }
        public string PrimaryAddressCity { get; set; }
        public string PrimaryAddressState { get; set; }
        public string PrimaryAddressPostcode { get; set; }
        public string PostalUnitAddress { get; set; }
        public string PostalBuildingAddress { get; set; }
        public string PostalAddressNumber { get; set; }
        public string PostalStreetAddress { get; set; }
        public string PoBoxAddress { get; set; }
        public string PostalCity { get; set; }
        public string PostalState { get; set; }
        public string PostalPostcode { get; set; }
        public int? ParticipantId { get; set; }
        public string PostalSuburb { get; set; }
    }
}
