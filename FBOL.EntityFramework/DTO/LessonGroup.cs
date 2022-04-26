using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.EntityFramework.DTO
{
    public class LessonGroup
    {
        public int LessonGroupId { get; set; }
        public int CourseId { get; set; }
        public int GroupId { get; set; }
        public int GroupSeq { get; set; }
        public int LessonId { get; set; }
        public int LessonSeq { get; set; }
        public string lesson_group_name { get; set; }
    }
}
