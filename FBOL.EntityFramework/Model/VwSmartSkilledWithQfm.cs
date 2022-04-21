using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwSmartSkilledWithQfm
    {
        public int ParticipantId { get; set; }
        public int? ProgramId { get; set; }
        public int QualificationId { get; set; }
        public byte QualOrderId { get; set; }
        public int FundingTypeId { get; set; }
        public string AntaCourseCode { get; set; }
        public string FundingTypeAbbr { get; set; }
        public string FmiUnitCode { get; set; }
        public int UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public int PartCompId { get; set; }
        public bool? Discontinued { get; set; }
    }
}
