using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwHousekeepingMismatchedDob
    {
        public int UserId { get; set; }
        public int? ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? EfDob { get; set; }
        public string UsiNotes { get; set; }
        public string Usi { get; set; }
        public byte UsiVerified { get; set; }
    }
}
