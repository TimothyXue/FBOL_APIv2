using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ExpectedEnrolment
    {
        public int ExpectedEnrolmentsId { get; set; }
        public short ProgramId { get; set; }
        public short Quantity { get; set; }
        public short CatscanLicenseId { get; set; }
    }
}
