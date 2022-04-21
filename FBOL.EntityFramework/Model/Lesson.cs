using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Lesson
    {
        public Lesson()
        {
            ActivityLessonDiscussionNavigations = new HashSet<ActivityLesson>();
            ActivityLessonLessonDueNavigations = new HashSet<ActivityLesson>();
            ActivityLessonLessons = new HashSet<ActivityLesson>();
            ActivityLessonLiveNavigations = new HashSet<ActivityLesson>();
            OnlineModules = new HashSet<OnlineModule>();
        }

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

        public virtual ICollection<ActivityLesson> ActivityLessonDiscussionNavigations { get; set; }
        public virtual ICollection<ActivityLesson> ActivityLessonLessonDueNavigations { get; set; }
        public virtual ICollection<ActivityLesson> ActivityLessonLessons { get; set; }
        public virtual ICollection<ActivityLesson> ActivityLessonLiveNavigations { get; set; }
        public virtual ICollection<OnlineModule> OnlineModules { get; set; }
    }
}
