using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.Mobile.Entityframework.Model
{
    public partial class Session
    {
        public int Id { get; set; }
        public Guid Key { get; set; }
        public int UserId { get; set; }
        public Guid Token { get; set; }
        public DateTime DateTime { get; set; }

        public virtual User User { get; set; }
    }
}
