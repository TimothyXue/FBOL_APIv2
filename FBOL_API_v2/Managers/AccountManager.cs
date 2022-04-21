﻿using FBOL.Mobile.Entityframework;
using FBOL.Mobile.Entityframework.Model;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FBOL_API_v2.Managers
{
    public class AccountManager
    {
        private  static SHA256Managed sha256 = new SHA256Managed();
        private static int saltLength = 32;
        public bool ValidateUser(string userName, string password)
        {
            FBOL.Mobile.Entityframework.DTO.User user = MobileDb.GetUserByUserName(userName);

            if (user != null)
            {
                byte[] passwordHash = GenerateSaltedPasswordHash(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)), Convert.FromBase64String(user.PasswordSalt));
                byte[] storedPasswordHash = Convert.FromBase64String(user.PasswordHash);

                return passwordHash.Length == storedPasswordHash.Length && passwordHash.SequenceEqual(storedPasswordHash);
            }

            return false;

        }
        public  FBOL.Mobile.Entityframework.DTO.User GetUser(int userId)
        {
            return MobileDb.GetUser(userId);
        }

        public  FBOL.Mobile.Entityframework.DTO.User GetUser(string userName)
        {
            return MobileDb.GetUserByUserName(userName);
        }

        private static byte[] GenerateSaltedPasswordHash(byte[] password, byte[] salt)
        {
            byte[] passwordSalted = new byte[password.Length + salt.Length];

            Array.Copy(password, passwordSalted, password.Length);
            Array.Copy(salt, 0, passwordSalted, password.Length, salt.Length);

            return sha256.ComputeHash(passwordSalted);
        }

    }
}
