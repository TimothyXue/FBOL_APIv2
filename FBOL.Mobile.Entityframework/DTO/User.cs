using System;

namespace FBOL.Mobile.Entityframework.DTO
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsConfirmed { get; set; }
        public string ConfirmationCode { get; set; }
        public bool IsActive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredFirstName { get; set; }
        public string PreferredLastName { get; set; }
        public DateTime LastLogin { get; set; }

        public string FullName
        {
            get
            {
                if (!String.IsNullOrEmpty(PreferredFirstName) && !String.IsNullOrEmpty(PreferredLastName))
                {
                    return PreferredFirstName + " " + PreferredLastName;
                }

                return FirstName + " " + LastName;
            }
        }
    }
}
