using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class DocumentList
    {
        public int DocumentListId { get; set; }
        public int? CourseId { get; set; }
        public int? FundingTypeId { get; set; }
        public string ListName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? OrderBy { get; set; }
    }
}
