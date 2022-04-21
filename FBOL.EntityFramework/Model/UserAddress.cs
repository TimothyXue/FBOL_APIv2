using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class UserAddress
    {
        public int UserAddressId { get; set; }
        public int UserId { get; set; }
        public string Building { get; set; }
        public string Unit { get; set; }
        public string PostalBox { get; set; }
        public string AddressNumber { get; set; }
        public string AddressLine { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Postcode { get; set; }
        public string Work1 { get; set; }
        public string Tag { get; set; }
        public string PostalBuilding { get; set; }
        public string PostalUnit { get; set; }
        public string PostalAddressNumber { get; set; }
        public string PostalAddressLine { get; set; }
        public string PostalTown { get; set; }
        public string PostalPostcode { get; set; }
        public string PostalState { get; set; }
        public string OtherCountries { get; set; }
    }
}
