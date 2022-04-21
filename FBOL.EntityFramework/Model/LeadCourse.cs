using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LeadCourse
    {
        public Guid Lcid { get; set; }
        public int ParticipantId { get; set; }
        public string NominationType { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Completed { get; set; }
    }
}
