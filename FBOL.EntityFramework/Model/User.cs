using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class User
    {
        public User()
        {
            FacilitatorComments = new HashSet<FacilitatorComment>();
            GeneralComments = new HashSet<GeneralComment>();
            GoalUsers = new HashSet<GoalUser>();
            ImperativeImportants = new HashSet<ImperativeImportant>();
            LicenseeAccessAccessLicensees = new HashSet<LicenseeAccess>();
            LicenseeAccessLicensees = new HashSet<LicenseeAccess>();
            ParticipantAccesses = new HashSet<ParticipantAccess>();
            Recognitions = new HashSet<Recognition>();
        }

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
        public string EmailAlt { get; set; }
        public int? EmailFormat { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool Facilitator { get; set; }
        public DateTime? LastLogonDate { get; set; }
        public bool? Licensee { get; set; }
        public bool? Coach { get; set; }
        public string PreferredFirstName { get; set; }
        public string LegalMiddleName { get; set; }
        public string PreferredLastName { get; set; }
        public string BusinessPhone { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? RecognitionDate { get; set; }
        public string RecognitionNotes { get; set; }
        public string PotwUser { get; set; }
        public string PotwPassword { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ActLicenseeName { get; set; }
        public string NationalStudentNumber { get; set; }
        public DateTime? Updated { get; set; }
        public string PpiLink { get; set; }
        public string JobTitle { get; set; }
        public string VettrakId { get; set; }
        public string Usi { get; set; }
        public byte UsiVerified { get; set; }
        public string UsiNotes { get; set; }
        public string UsiFirstNames { get; set; }
        public string UsiLastName { get; set; }
        public string EmailSignature { get; set; }
        public string AddressToSendCert { get; set; }
        public string OtherCountries { get; set; }

        public virtual ICollection<FacilitatorComment> FacilitatorComments { get; set; }
        public virtual ICollection<GeneralComment> GeneralComments { get; set; }
        public virtual ICollection<GoalUser> GoalUsers { get; set; }
        public virtual ICollection<ImperativeImportant> ImperativeImportants { get; set; }
        public virtual ICollection<LicenseeAccess> LicenseeAccessAccessLicensees { get; set; }
        public virtual ICollection<LicenseeAccess> LicenseeAccessLicensees { get; set; }
        public virtual ICollection<ParticipantAccess> ParticipantAccesses { get; set; }
        public virtual ICollection<Recognition> Recognitions { get; set; }
    }
}
