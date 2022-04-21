using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Lln
    {
        public int LlnId { get; set; }
        public string XslTemplate { get; set; }
        public int MaxScore { get; set; }
        public int PassScore { get; set; }
        public int VersionNo { get; set; }
        public string Answers { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
