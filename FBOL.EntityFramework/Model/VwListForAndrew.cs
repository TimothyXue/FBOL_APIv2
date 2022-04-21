using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwListForAndrew
    {
        public string Client { get; set; }
        public string Industry { get; set; }
        public string Category { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public int? CatscanHistoryId { get; set; }
        public string RegistrationStatus { get; set; }
        public string RegistrationType { get; set; }
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ParticipantSPhone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string MmFirstName { get; set; }
        public string MmLastName { get; set; }
        public string MmEmail { get; set; }
        public string DmName { get; set; }
        public string DmJobTitle { get; set; }
        public string DmPhone { get; set; }
        public string DmEmail { get; set; }
        public string CompanyPhone { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? Employees { get; set; }
        public string Lincesee { get; set; }
    }
}
