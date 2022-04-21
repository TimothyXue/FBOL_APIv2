using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class InvoicePayment
    {
        public int ProgramId { get; set; }
        public short Invoice { get; set; }
        public int LicenseeId { get; set; }
        public string Amount { get; set; }
        public DateTime? Paid { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
