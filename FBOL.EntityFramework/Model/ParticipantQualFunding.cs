using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ParticipantQualFunding
    {
        public int PartFundingId { get; set; }
        public int ParticipantId { get; set; }
        public int QualStateFundingId { get; set; }
        public byte QualOrderId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
