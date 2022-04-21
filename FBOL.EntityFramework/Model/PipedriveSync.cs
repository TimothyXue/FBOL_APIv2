using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class PipedriveSync
    {
        public int PipedriveId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
        public string PdTags { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastGrad { get; set; }
    }
}
