using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Bulletin
    {
        public int ProgramId { get; set; }
        public DateTime BulletinDate { get; set; }
        public string Notice { get; set; }
    }
}
