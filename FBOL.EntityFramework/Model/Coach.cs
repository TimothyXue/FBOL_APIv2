using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Coach
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string StateCode { get; set; }
    }
}
