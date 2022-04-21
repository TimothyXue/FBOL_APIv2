using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Workbook
    {
        public int ReviewQuestionId { get; set; }
        public int ParticipantId { get; set; }
        public string Response { get; set; }
        public bool Completed { get; set; }
        public DateTime LastEdited { get; set; }
    }
}
