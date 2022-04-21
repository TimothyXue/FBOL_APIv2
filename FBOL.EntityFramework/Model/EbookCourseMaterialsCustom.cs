using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class EbookCourseMaterialsCustom
    {
        public int EbookCourseMaterialsCustomId { get; set; }
        public string EbookToken { get; set; }
        public string EbookTitle { get; set; }
        public string EbookUrn { get; set; }
        public string CompanyLogo { get; set; }
    }
}
