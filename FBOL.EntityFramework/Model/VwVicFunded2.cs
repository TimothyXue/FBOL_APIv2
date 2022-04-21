using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwVicFunded2
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneMobile { get; set; }
        public string UniqueStudentIdentifier { get; set; }
        public string Expr1 { get; set; }
        public string Expr2 { get; set; }
        public string FmiUnitCode { get; set; }
        public string FmiUnitTitle { get; set; }
        public string FmiUnitDesc { get; set; }
        public DateTime? OverviewDate { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string LocationName { get; set; }
        public int PartCompId { get; set; }
        public int FmiUnitId { get; set; }
        public int QualificationId { get; set; }
    }
}
