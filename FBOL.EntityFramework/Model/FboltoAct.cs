using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class FboltoAct
    {
        public int? UserId { get; set; }
        public string Licensee { get; set; }
        public int? ProgramId { get; set; }
        public string CourseCode { get; set; }
        public DateTime? OverviewDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public string MmFirstName { get; set; }
        public string MmLastName { get; set; }
        public string MmCombinedName { get; set; }
        public string CoachCombinedName { get; set; }
        public string Type { get; set; }
        public string CertIssued { get; set; }
        public int? MmUserId { get; set; }
        public int? CoachUserId { get; set; }
        public string PartName { get; set; }
        public string PartFirstName { get; set; }
        public string PartLastName { get; set; }
        public string PartId { get; set; }
        public string PartEmail { get; set; }
        public string PartCompany { get; set; }
        public string PartCompanyAdd1 { get; set; }
        public string PartCompanyAdd2 { get; set; }
        public string PartCompanyCity { get; set; }
        public string PartCompanyState { get; set; }
        public string PartCompanyPostcode { get; set; }
        public string PartHomeAdd1 { get; set; }
        public string PartHomeAdd2 { get; set; }
        public string PartHomeCity { get; set; }
        public string PartHomeState { get; set; }
        public string PartHomePostcode { get; set; }
        public DateTime? PartDob { get; set; }
        public string PartBusinessPhone { get; set; }
        public string PartMobile { get; set; }
        public string PartPhone { get; set; }
        public string PartFax { get; set; }
        public string MmEmail { get; set; }
        public string MmCompany { get; set; }
        public string MmCompanyAdd1 { get; set; }
        public string MmCompanyAdd2 { get; set; }
        public string MmCompanyCity { get; set; }
        public string MmCompanyState { get; set; }
        public string MmCompanyPostcode { get; set; }
        public string MmHomeAdd1 { get; set; }
        public string MmHomeAdd2 { get; set; }
        public string MmHomeCity { get; set; }
        public string MmHomeState { get; set; }
        public string MmHomePostcode { get; set; }
        public DateTime? MmDob { get; set; }
        public string MmBusinessPhone { get; set; }
        public string MmMobile { get; set; }
        public string MmPhone { get; set; }
        public string MmFax { get; set; }
        public int? PartRecord { get; set; }
        public int? MmRecord { get; set; }
    }
}
