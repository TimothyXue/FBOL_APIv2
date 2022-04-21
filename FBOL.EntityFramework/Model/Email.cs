using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Email
    {
        public int EmailId { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
