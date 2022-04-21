using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class RoleType
    {
        public string RoleTypeCode { get; set; }
        public string RoleTypeDesc { get; set; }
        public bool? IsLicensee { get; set; }
        public bool? IsCoach { get; set; }
        public bool? IsManagermentor { get; set; }
        public bool? IsObserver { get; set; }
    }
}
