using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class AllTypeValue
    {
        public int TypeValueId { get; set; }
        public int TypeId { get; set; }
        public string DisplayValue { get; set; }
        public int? SortOrder { get; set; }
        public string DbValue { get; set; }
        public int? DbValueSchemaTypeId { get; set; }
    }
}
