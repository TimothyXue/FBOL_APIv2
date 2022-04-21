using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class LearningseatResult
    {
        public int LearningseatId { get; set; }
        public string Companyid { get; set; }
        public string Username { get; set; }
        public string Learningcode { get; set; }
        public string Completionstatus { get; set; }
        public string Score { get; set; }
        public string StartDate { get; set; }
        public string CompletionDate { get; set; }
        public string DateLastUpdated { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
