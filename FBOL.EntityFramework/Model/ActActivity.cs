using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ActActivity
    {
        public Guid Historyid { get; set; }
        public string Userlogin { get; set; }
        public string Activity { get; set; }
        public string Result { get; set; }
        public DateTime? Date { get; set; }
    }
}
