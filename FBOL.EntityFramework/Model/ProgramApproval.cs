using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ProgramApproval
    {
        public int ProgramId { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? OverviewDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string StateCode { get; set; }
        public bool? DisableEmail { get; set; }
        public string Notes { get; set; }
        public string Requestor { get; set; }
        public string AddressFup { get; set; }
        public int? LocationId { get; set; }
        public string PostCode { get; set; }
        public string Suburb { get; set; }
        public int? PpbId { get; set; }
        public string BuildingName { get; set; }
        public string UnitDetails { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }

        public virtual Program Program { get; set; }
    }
}
