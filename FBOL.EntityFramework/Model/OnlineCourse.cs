using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class OnlineCourse
    {
        public OnlineCourse()
        {
            OnlineModules = new HashSet<OnlineModule>();
        }

        public int OnlineCourseId { get; set; }
        public string OnlineCourseTitle { get; set; }

        public virtual ICollection<OnlineModule> OnlineModules { get; set; }
    }
}
