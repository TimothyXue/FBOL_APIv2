using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Auspost
    {
        public int AuspostId { get; set; }
        public string Postcode { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string StateNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
