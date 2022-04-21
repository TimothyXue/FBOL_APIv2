using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActivityComment
    {
        public int ActivityCommentId { get; set; }
        public int ParticipantId { get; set; }
        public int? ActivityDetailId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime? CommentDate { get; set; }
        public int? Admin { get; set; }

        public virtual ActivityDetail ActivityDetail { get; set; }
        public virtual Participant Participant { get; set; }
    }
}
