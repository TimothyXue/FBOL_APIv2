using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwVettrakClientsB
    {
        public string IndigenousStatus { get; set; }
        public string ProficiencyInSpokenEnglish { get; set; }
        public string HaveDisablity { get; set; }
        public string Disabilities { get; set; }
        public string HavePriorEducation { get; set; }
        public string PriorEducation { get; set; }
        public string AtSchool { get; set; }
        public short CountryOfBirth { get; set; }
        public string SchoolLevel { get; set; }
        public int? LabourForceStatus { get; set; }
        public short? LanguageSpokenAtHome { get; set; }
        public short Citizenship { get; set; }
        public string Usi { get; set; }
        public string BirthTown { get; set; }
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
    }
}
