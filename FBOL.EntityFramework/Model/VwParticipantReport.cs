using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantReport
    {
        public string FundingTypeAbbr { get; set; }
        public string CourseCode { get; set; }
        public int? ProgramId { get; set; }
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
