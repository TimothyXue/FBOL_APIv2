using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CertificateText
    {
        public int TextId { get; set; }
        public string Text { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? RelatedTextId { get; set; }
        public string StateCode { get; set; }
    }
}
