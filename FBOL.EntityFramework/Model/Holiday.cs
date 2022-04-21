using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Holiday
    {
        public int HolidayId { get; set; }
        public string Description { get; set; }
        public DateTime HolidayDate { get; set; }
        public string StateCode { get; set; }
    }
}
