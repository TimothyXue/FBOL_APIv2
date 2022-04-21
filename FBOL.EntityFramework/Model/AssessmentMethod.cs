using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class AssessmentMethod
    {
        public int AssessmentMethodId { get; set; }
        public string AssessmentDesc { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
