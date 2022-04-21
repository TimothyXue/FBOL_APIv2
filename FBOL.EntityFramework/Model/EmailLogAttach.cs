using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EmailLogAttach
    {
        public int EmailLogAttachId { get; set; }
        public int EmailLogId { get; set; }
        public string FileNameFullWs { get; set; }
        public string FileNameFullDb { get; set; }
    }
}
