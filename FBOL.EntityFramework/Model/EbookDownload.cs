using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EbookDownload
    {
        public int EbookDownloadId { get; set; }
        public int EbookCourseMaterialId { get; set; }
        public int ParticipantId { get; set; }
        public int DownloadCount { get; set; }
        public bool? AllowDownload { get; set; }
        public string DownloadLink { get; set; }
    }
}
