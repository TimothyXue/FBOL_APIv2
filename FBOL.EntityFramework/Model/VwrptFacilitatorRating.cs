using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwrptFacilitatorRating
    {
        public string Facilitator { get; set; }
        public double? AverageRating { get; set; }
        public int? NumRatings { get; set; }
    }
}
