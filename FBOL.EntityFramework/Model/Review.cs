using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Review
    {
        public int UserId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime? WinWinDate { get; set; }
        public DateTime? BulletinDate { get; set; }
    }
}
