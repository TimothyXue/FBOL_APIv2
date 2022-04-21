using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class RelatedPerson
    {
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public string RoleTypeCode { get; set; }
        public DateTime? WelcomeEmailDate { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? LastViewed { get; set; }
        public int? OldUserId { get; set; }
        public bool? TeamViewNom1 { get; set; }
        public bool? TeamViewNom2 { get; set; }
        public int? PpbId { get; set; }
        public int? LicenseeId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
