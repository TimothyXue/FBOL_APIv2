using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class AnzscoCodesAdditional
    {
        public string Code { get; set; }
        public string Major { get; set; }
        public string Submajor { get; set; }
        public string Minor { get; set; }
        public string Unit { get; set; }
        public string Occupation { get; set; }
        public int ProgramId { get; set; }
    }
}
