using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Recognition
    {
        public int RecognitionId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public DateTime? RecognitionDate { get; set; }
        public string Comments { get; set; }

        public virtual User User { get; set; }
    }
}
