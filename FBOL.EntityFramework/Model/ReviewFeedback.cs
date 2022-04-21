using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ReviewFeedback
    {
        public int UserId { get; set; }
        public int WorkshopId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
