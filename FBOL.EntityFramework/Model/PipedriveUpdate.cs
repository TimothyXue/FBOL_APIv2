using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PipedriveUpdate
    {
        public int Id { get; set; }
        public int PipedriveId { get; set; }
        public string Field { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Updated { get; set; }
    }
}
