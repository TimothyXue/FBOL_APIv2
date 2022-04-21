using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActivityLesson
    {
        public int LessonId { get; set; }
        public int ActivityId { get; set; }
        public int AlVersion { get; set; }
        public int? LessonDue { get; set; }
        public int? DuePlus { get; set; }
        public int? Live { get; set; }
        public int? LivePlus { get; set; }
        public int? Discussion { get; set; }
        public int? DiscussionPlus { get; set; }
        public int? Seq { get; set; }
        public string ManualRef { get; set; }
        public DateTime? HideBefore { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Lesson DiscussionNavigation { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual Lesson LessonDueNavigation { get; set; }
        public virtual Lesson LiveNavigation { get; set; }
    }
}
