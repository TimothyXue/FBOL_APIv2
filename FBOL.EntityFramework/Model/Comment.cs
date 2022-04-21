using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Comment
    {
        public int WorkshopId { get; set; }
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public DateTime CommentDate { get; set; }
        public string Comment1 { get; set; }
    }
}
