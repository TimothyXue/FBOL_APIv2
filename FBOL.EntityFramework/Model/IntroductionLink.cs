using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class IntroductionLink
    {
        public int IntroLinkId { get; set; }
        public int? CourseId { get; set; }
        public string IntroLinkTitle { get; set; }
        public string IntroLinkRef { get; set; }
        public int? OrderBy { get; set; }
    }
}
