using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class StateFundingSourceCode
    {
        public int SfscId { get; set; }
        public int ParticipantId { get; set; }
        public int QualificationId { get; set; }
        public string Code { get; set; }
    }
}
