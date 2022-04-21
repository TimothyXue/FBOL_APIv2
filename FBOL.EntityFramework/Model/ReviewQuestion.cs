using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ReviewQuestion
    {
        public int ReviewQuestionId { get; set; }
        public int CourseId { get; set; }
        public int Item { get; set; }
        public int Section { get; set; }
        public string QuestionPre { get; set; }
        public int? ResponseLength { get; set; }
        public string QuestionPost { get; set; }
        public bool Archived { get; set; }
    }
}
