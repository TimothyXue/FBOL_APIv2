using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ExtractAuditType
    {
        public int ExtractAuditTypeId { get; set; }
        public string ExtractAuditType1 { get; set; }
        public bool IsEmailSend { get; set; }
        public bool? UseBatchOrHeaderId { get; set; }
        public string SpName { get; set; }
    }
}
