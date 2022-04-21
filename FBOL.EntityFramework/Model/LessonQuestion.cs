using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LessonQuestion
    {
        public LessonQuestion()
        {
            AssessmentMatrices = new HashSet<AssessmentMatrix>();
        }

        public int LessonQuestionId { get; set; }
        public int LessonId { get; set; }
        public int Item { get; set; }
        public int Seq { get; set; }
        public string QuestionPre { get; set; }
        public int? ResponseLength { get; set; }
        public string QuestionPost { get; set; }
        public bool Archived { get; set; }
        public string CompetencyLog { get; set; }
        public int? Accomplishment { get; set; }

        public virtual ICollection<AssessmentMatrix> AssessmentMatrices { get; set; }
    }
}
