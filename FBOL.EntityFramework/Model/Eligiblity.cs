using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Eligiblity
    {
        public int EligiblePersonId { get; set; }
        public string Course { get; set; }
        public bool? Citizen { get; set; }
        public bool? PermanentResident { get; set; }
        public bool? SpecialVisa { get; set; }
        public bool? AsylumSeeker { get; set; }
        public bool? ProtectionVisa { get; set; }
        public string Age { get; set; }
        public string Qualification { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public DateTime? Created { get; set; }
        public int? Eligible { get; set; }
    }
}
