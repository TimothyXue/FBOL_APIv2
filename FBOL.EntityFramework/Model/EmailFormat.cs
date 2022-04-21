using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EmailFormat
    {
        public int EmailFormatId { get; set; }
        public string EmailType { get; set; }
        public string EmailHead { get; set; }
        public string EmailBottom { get; set; }
        public bool? EmailSaved { get; set; }
        public string Letter { get; set; }
    }
}
