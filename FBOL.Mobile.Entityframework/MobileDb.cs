using FBOL.Mobile.Entityframework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.Mobile.Entityframework
{
    public  class MobileDb
    {
        public static DTO.User GetUserByUserName(string userName)
        {
            using (FBOLMobileContext ctx = new FBOLMobileContext())
            {

                Model.User usr = ctx.Users.Where(x => (x.UserName.ToLower() == userName.Trim().ToLower())).FirstOrDefault();

                return DtoConvertor.ConvertToDto(usr);

            }
        }

        public static DTO.User GetUser(int id)
        {
            using (FBOLMobileContext ctx = new FBOLMobileContext())
            {
                return DtoConvertor.ConvertToDto(ctx.Users.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        public static List<DTO.User> GetUsers()
        {
            using (FBOLMobileContext ctx = new FBOLMobileContext())
            {
                return ctx.Users.ToList().ConvertAll(DtoConvertor.ConvertToDto);
            }
        }
    }
}
