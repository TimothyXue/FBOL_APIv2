using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwCoachesByProgram
    {
        public int ProgramId { get; set; }
        public int ParticipantId { get; set; }
        public int? FacilitatorUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CoachUserId { get; set; }
        public int UserId { get; set; }
        public string RoleTypeCode { get; set; }
        public string CoachFirstName { get; set; }
        public string CoachLastName { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? WelcomeEmailDate { get; set; }
        public string FacilitatorFirstName { get; set; }
        public string FacilitatorLastName { get; set; }
        public string Company { get; set; }
        public DateTime? OverviewDate { get; set; }
        public string LocationName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
