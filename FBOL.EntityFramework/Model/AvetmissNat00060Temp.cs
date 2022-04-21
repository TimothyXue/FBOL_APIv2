using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class AvetmissNat00060Temp
    {
        public string ModuleUnitOfCompetencyFlag { get; set; }
        public string ModuleUnitOfCompetencyIdentifier { get; set; }
        public string ModuleUnitOfCompetencyName { get; set; }
        public string ModuleUnitOfCompetencyFoeIdentifier { get; set; }
        public string VetFlag { get; set; }
        public short? NominalHours { get; set; }
        public short? NominalHoursQld { get; set; }
        public short? NominalHoursNsw { get; set; }
        public short? NominalHoursSa { get; set; }
        public short? NominalHoursTas { get; set; }
        public short? NominalHoursWa { get; set; }
        public int? FmiUnitId { get; set; }
        public int Id { get; set; }
    }
}
