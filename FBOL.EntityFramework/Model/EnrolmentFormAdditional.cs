using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EnrolmentFormAdditional
    {
        public int EnrolFormAdditionalId { get; set; }
        public int ParticipantId { get; set; }
        public string RoleName { get; set; }
        public byte GroupNoIsPrevious { get; set; }
        public int NumYears { get; set; }
        public int NumMonths { get; set; }
        public int NumberOfStaffLed { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
