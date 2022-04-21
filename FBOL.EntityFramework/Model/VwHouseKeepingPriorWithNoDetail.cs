using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwHouseKeepingPriorWithNoDetail
    {
        public int? UserId { get; set; }
        public int? ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? PriorEducation { get; set; }
        public byte? Degree { get; set; }
        public byte? AdvDiploma { get; set; }
        public byte? Diploma { get; set; }
        public byte? CertIv { get; set; }
        public byte? CertIii { get; set; }
        public byte? CertIi { get; set; }
        public byte? CertI { get; set; }
        public byte? CertOther { get; set; }
    }
}
