using FBOL.Mobile.Entityframework.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.Mobile.Entityframework
{
    public  class MobileDb
    {
        private readonly IConfiguration _config;

        public MobileDb(IConfiguration config)
        {
            _config = config;
        }

        public  DTO.User GetUserByUserName(string userName)
        {
            using (FBOLMobileContext ctx = new FBOLMobileContext(_config))
            {

                Model.User usr = ctx.Users.Where(x => (x.UserName.ToLower() == userName.Trim().ToLower())).FirstOrDefault();

                return DtoConvertor.ConvertToDto(usr);

            }
        }

        public  DTO.User GetUser(int id)
        {
            using (FBOLMobileContext ctx = new FBOLMobileContext(_config))
            {
                return DtoConvertor.ConvertToDto(ctx.Users.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        public  List<DTO.User> GetUsers()
        {
            using (FBOLMobileContext ctx = new FBOLMobileContext(_config))
            {
                return ctx.Users.ToList().ConvertAll(DtoConvertor.ConvertToDto);
            }
        }
    }
}
