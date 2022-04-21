using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EbookDownloadsCustom
    {
        public int EbookDownloadsCustomId { get; set; }
        public string EbookToken { get; set; }
        public int UserId { get; set; }
    }
}
