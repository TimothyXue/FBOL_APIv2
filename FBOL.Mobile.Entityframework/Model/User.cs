using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.Mobile.Entityframework.Model
{
    public partial class User
    {
        public User()
        {
            Sessions = new HashSet<Session>();
        }

        public int Id { get; set; }
        public Guid Key { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsConfirmed { get; set; }
        public string ConfirmationCode { get; set; }
        public bool? IsActive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredFirstName { get; set; }
        public string PreferredLastName { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
