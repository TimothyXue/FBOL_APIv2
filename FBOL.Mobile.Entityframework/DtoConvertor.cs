using FBOL.Mobile.Entityframework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.Mobile.Entityframework
{
    internal class DtoConvertor
    {
        public static DTO.User ConvertToDto(User entity)
        {
            if (entity == null)
            {
                return null;
            }

            DTO.User dto = new DTO.User()
            {
                Id = entity.Id,
                UserName = entity.UserName,
                UserId = entity.UserId,
                PasswordHash = entity.PasswordHash,
                PasswordSalt = entity.PasswordSalt,
                IsConfirmed = entity.IsConfirmed,
                ConfirmationCode = entity.ConfirmationCode,
                IsActive = (bool)entity.IsActive,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                EmailAddress = entity.EmailAddress
            };

            return dto;
        }

    }
}
