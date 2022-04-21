using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class MajorClient
    {
        public int MajorClientId { get; set; }
        public string ClientName { get; set; }
        public string Url { get; set; }
    }
}
