using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwManagerMentorInEnrolleeVersusRelatedParty
    {
        public int EnrolleeId { get; set; }
        public int ProgramId { get; set; }
        public int Priority { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string MmFirstName { get; set; }
        public string MmLastName { get; set; }
        public string MmCompany { get; set; }
        public string Expr1 { get; set; }
        public string Expr2 { get; set; }
        public string RoleTypeCode { get; set; }
        public string CourseCode { get; set; }
        public DateTime? OverviewDate { get; set; }
    }
}
