using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.EntityFramework.DTO
{
    public class ActivityDetail
    {
        public int ActivityDetailId { get; set; }
        public int ActivityId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string XmlTemplate { get; set; }
        public bool? Paper { get; set; }
        public DateTime? Completed { get; set; }
        public DateTime? Assessed { get; set; }
        public int? Status { get; set; }
        public string WorkareaUrl { get; set; }
        public DateTime? SubmitToMm { get; set; }
        public string XmlActivityData { get; set; }
        public string XmlActivityDataBackup { get; set; }
        public int? ReviewerParticipantId { get; set; }

    }
}
