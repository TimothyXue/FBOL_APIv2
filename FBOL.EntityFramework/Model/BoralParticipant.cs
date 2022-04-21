using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class BoralParticipant
    {
        public string Participant { get; set; }
        public string Company { get; set; }
        public string CourseType { get; set; }
        public string StartDate { get; set; }
        public string Location { get; set; }
        public string ManagerMentor { get; set; }
        public string Fef { get; set; }
        public string TrainingPlanCompleted { get; set; }
        public string Status { get; set; }
        public string WdDeffNotes { get; set; }
        public string DateOfWdDeffTransferred { get; set; }
        public string CourseGraduation { get; set; }
        public string QualificationIssued { get; set; }
        public string Qualification { get; set; }
        public string LastActiveModule { get; set; }
        public int? SalePrice { get; set; }
    }
}
