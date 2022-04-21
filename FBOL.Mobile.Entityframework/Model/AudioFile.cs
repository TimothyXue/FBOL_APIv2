using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.Mobile.Entityframework.Model
{
    public partial class AudioFile
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string ModuleName { get; set; }
        public int TrackNumber { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public int Duration { get; set; }
    }
}
