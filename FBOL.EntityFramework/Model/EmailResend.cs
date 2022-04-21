using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EmailResend
    {
        public int MailitemId { get; set; }
        public DateTime ResendDate { get; set; }
    }
}
