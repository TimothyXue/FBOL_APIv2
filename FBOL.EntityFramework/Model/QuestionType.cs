using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class QuestionType
    {
        public int QtypeCourseId { get; set; }
        public string CourseCode { get; set; }
        public byte QuestionTypeId { get; set; }
        public int QuestionNumber { get; set; }
        public string McrPcr { get; set; }
    }
}
