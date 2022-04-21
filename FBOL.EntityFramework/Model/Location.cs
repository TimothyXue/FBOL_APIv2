using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Location
    {
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string StateCode { get; set; }
        public string PostCode { get; set; }
        public string VenueCode { get; set; }
        public int LocationId { get; set; }
        public string MapName { get; set; }
        public DateTime? Archived { get; set; }
        public string Suburb { get; set; }
        public bool? Regional { get; set; }
        public int? PpbId { get; set; }
        public string BuildingName { get; set; }
        public string UnitDetails { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string VettrakId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Updated { get; set; }
    }
}
