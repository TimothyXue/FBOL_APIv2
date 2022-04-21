using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class GeneralComment
    {
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public DateTime CommentDate { get; set; }
        public string Comment { get; set; }
        public int? Section { get; set; }

        public virtual Participant Participant { get; set; }
        public virtual User User { get; set; }
    }
}
