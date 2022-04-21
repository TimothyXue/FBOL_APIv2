using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwHouseKeepingDuplicatePostcodesForHomeCity
    {
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public int? CountPostcode { get; set; }
    }
}
