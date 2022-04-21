using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class WorkflowEvent
    {
        public int WorkflowEventId { get; set; }
        public string WorkflowNameOrId { get; set; }
        public int EventStageId { get; set; }
        public string EventNameOrId { get; set; }
        public int ParticipantId { get; set; }
        public string EventData { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
