using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ImperativeImportant
    {
        public int ImperativeImportantId { get; set; }
        public int UserId { get; set; }
        public DateTime? Created { get; set; }
        public int? Imperative { get; set; }
        public string Priority { get; set; }
        public string Task { get; set; }
        public DateTime? Completed { get; set; }
        public int? ParticipantId { get; set; }

        public virtual User User { get; set; }
    }
}
