using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.EntityFramework.DTO
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public int CourseId { get; set; }
        public int LessonSeq { get; set; }
        public string LessonName { get; set; }
        public string LessonTitle { get; set; }
        public string LearningOutcomeTitle { get; set; }
        public int? FmiElementId { get; set; }
        public string AssignmentEmail { get; set; }
        public decimal LessonDuration { get; set; }
        public int DaysSincePrevLesson { get; set; }
        public string Extras { get; set; }
        public bool? FacBill1 { get; set; }
        public bool? FacBill2 { get; set; }
        public bool? LeadDiscussion { get; set; }
        public string CoursePart { get; set; }
        public bool? TeamView2 { get; set; }
        public bool? FirstLesson { get; set; }
        public bool? LastLesson { get; set; }

    }
}
