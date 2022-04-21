using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ExtractTag
    {
        public int ExtractTagId { get; set; }
        public string ExtractTag1 { get; set; }
        public string ExtractTageDescription { get; set; }
        public int? ExtractTagScopeExtractId { get; set; }
    }
}
