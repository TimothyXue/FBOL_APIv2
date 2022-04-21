using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EnrolmentFormNz
    {
        public int Id { get; set; }
        public int? ParticipantId { get; set; }
        public string NsnNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string EthnicGroup { get; set; }
        public DateTime? PrivacyAgreement { get; set; }
        public bool? AddressIsCompany { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
