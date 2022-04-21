using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FundingInvoiceRequestBackup
    {
        public int InvoiceRequestId { get; set; }
        public int Licensee { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
