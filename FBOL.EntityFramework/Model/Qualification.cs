using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Qualification
    {
        public int QualificationId { get; set; }
        public string AntaCourseCode { get; set; }
        public short? QualLevel { get; set; }
        public string QualCode { get; set; }
        public string QualLevelTitle { get; set; }
        public string QualTitle { get; set; }
        public string NominalHoursVic { get; set; }
        public string NominalHoursQld { get; set; }
        public string NominalHoursNsw { get; set; }
        public string NominalHoursSa { get; set; }
        public string NominalHoursWa { get; set; }
        public string NominalHoursTas { get; set; }
        public string NominalHoursAct { get; set; }
        public string NominalHoursNt { get; set; }
        public string LoeIdentifier { get; set; }
        public string FoeIdentifier { get; set; }
        public string AnzscoIdentifier { get; set; }
        public string CpsNumber { get; set; }
        public string NextQualLevel { get; set; }
        public string QualStatus { get; set; }
        public string GovtContribution { get; set; }
    }
}
