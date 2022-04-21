using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class MailingListImport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrganisationName { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string SecondaryEmailAddress { get; set; }
        public string Fax { get; set; }
        public string CourseParticipant { get; set; }
        public string CourseManager { get; set; }
        public string InterestedIn { get; set; }
        public string ImportedFrom { get; set; }
        public int? LicenseId { get; set; }
        public string PreviousDealings { get; set; }
        public string Country { get; set; }
        public string Message { get; set; }
        public DateTime? OriginalDate { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Imported { get; set; }
        public DateTime? Updated { get; set; }
    }
}
