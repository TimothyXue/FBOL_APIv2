using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EmailLog
    {
        public int EmailLogId { get; set; }
        public int ParticipantId { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? SentDate { get; set; }
        public string BodyType { get; set; }
    }
}
