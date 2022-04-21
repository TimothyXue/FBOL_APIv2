using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class UsersOrphaned
    {
        public int UserId { get; set; }
        public string LogonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyPostcode { get; set; }
        public string HomeAddress1 { get; set; }
        public string HomeAddress2 { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomePostcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool Facilitator { get; set; }
        public DateTime? LastLogonDate { get; set; }
        public bool? Licensee { get; set; }
        public string PreferredName { get; set; }
        public string BusinessPhone { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? RecognitionDate { get; set; }
        public string RecognitionNotes { get; set; }
    }
}
