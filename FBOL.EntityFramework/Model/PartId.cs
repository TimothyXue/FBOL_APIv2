using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PartId
    {
        public long Id { get; set; }
        public int PId { get; set; }
        public string InsertSourceInd { get; set; }
        public DateTime WhenInserted { get; set; }
    }
}
