using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class MobileSession
    {
        public int Id { get; set; }
        public Guid Key { get; set; }
        public int UserId { get; set; }
        public Guid Token { get; set; }
        public DateTime DateTime { get; set; }
    }
}
