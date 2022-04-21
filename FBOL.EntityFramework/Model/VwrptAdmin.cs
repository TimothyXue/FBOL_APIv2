using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwrptAdmin
    {
        public string Participant { get; set; }
        public string Course { get; set; }
        public string Overview { get; set; }
        public string Quals { get; set; }
        public string Licensee { get; set; }
        public string Company { get; set; }
        public int UserId { get; set; }
        public string State { get; set; }
        public string Expr1 { get; set; }
        public string Expr2 { get; set; }
    }
}
