using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class HideActivityByProgram
    {
        public int ProgramId { get; set; }
        public int ActivityId { get; set; }
    }
}
