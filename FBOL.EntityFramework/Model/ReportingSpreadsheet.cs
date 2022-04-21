using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class ReportingSpreadsheet
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ParticipantId { get; set; }
        public string UnitCode { get; set; }
        public string QualCode { get; set; }
        public string ReportTo { get; set; }
        public string StateFunding { get; set; }
        public string FedFunding { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string OverviewDate { get; set; }
        public string CourseState { get; set; }
        public string OverrideState { get; set; }
        public string CommencementDate { get; set; }
        public string Status { get; set; }
        public string StatusChangeDate { get; set; }
        public string Exclude { get; set; }
        public int? YearWithdrawn { get; set; }
        public string EvidenceDate { get; set; }
        public string SalesPerson { get; set; }
        public string CompanyName { get; set; }
        public bool IncludeInNatFilesIfNoTp { get; set; }
        public bool ExcludeFromTpMissingEmail { get; set; }
        public string ExcludeFromReport { get; set; }
        public string CertificateWaiver { get; set; }
        public bool? TrainingOccursAtWorkplace { get; set; }
        public bool InHouse { get; set; }
        public string VettrakId { get; set; }
    }
}
