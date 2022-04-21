using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwHousekeepingParticipantEnrolmentFormWrongUserId
    {
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public int? EnrolformUserId { get; set; }
    }
}
