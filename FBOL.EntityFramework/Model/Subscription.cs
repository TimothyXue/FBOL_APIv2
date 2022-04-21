using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Subscription
    {
        public Guid SubscriptionId { get; set; }
        public string Email { get; set; }
        public bool? Newsletter { get; set; }
        public bool? Lead { get; set; }
        public DateTime? Updated { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public int? A1 { get; set; }
        public int? A2 { get; set; }
        public int? A3 { get; set; }
        public int? A4 { get; set; }
        public int? A5 { get; set; }
        public int? A6 { get; set; }
        public int? A7 { get; set; }
        public int? A8 { get; set; }
        public int? A9 { get; set; }
        public int? A10 { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public int? LeadIdEmp { get; set; }
        public int? LeadIdMgr { get; set; }
        public int? LeadIdBus { get; set; }
        public int? LeadSurveyVersion { get; set; }
        public DateTime? LeadRequest { get; set; }
        public int? ParticipantId { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Postcode { get; set; }
    }
}
