using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LearningseatRaw
    {
        public string Company { get; set; }
        public string UserId { get; set; }
        public string Learningcode { get; set; }
        public string Status { get; set; }
        public int? Score { get; set; }
        public string Start { get; set; }
        public string Completion { get; set; }
        public string LastUpdate { get; set; }
        public string Extra { get; set; }
    }
}
