using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwLeadresult
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ParticipantId { get; set; }
        public string Email { get; set; }
        public Guid Lcid { get; set; }
        public string NominationType { get; set; }
        public string Fullname { get; set; }
        public string SurveyRespondantEmail { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ActivityDetailId { get; set; }
        public DateTime? ActivityDate { get; set; }
        public DateTime? Completed { get; set; }
        public DateTime? Assessed { get; set; }
        public int? Status { get; set; }
    }
}
