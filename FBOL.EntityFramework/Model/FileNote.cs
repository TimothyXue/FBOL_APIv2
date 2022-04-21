using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FileNote
    {
        public int FileNoteId { get; set; }
        public string Subject { get; set; }
        public string Note { get; set; }
        public int? Author { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ParticipantId { get; set; }
    }
}
