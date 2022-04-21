using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FacilitatorComment
    {
        public int FacilitatorCommentId { get; set; }
        public int UserId { get; set; }
        public string FacilitatorComment1 { get; set; }

        public virtual User User { get; set; }
    }
}
