using FBOL.Mobile.Entityframework.DTO;

using FBOL_API_v2.Managers;
using FBOL_API_v2.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace FBOL_API_v2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller
    {
        private IConfiguration _config;

        public AccountController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            var user = Authenticate(userLogin);

            if (user != null)
            {
                var token = Generate(user);
                return Ok(token);
            }

            return NotFound("User not found");
        }

        private User Authenticate(UserLogin userLogin)
        {
            AccountManager _am = new AccountManager(_config);
            try
            {
                if (_am.ValidateUser(userLogin.UserName.Trim(), userLogin.Password))
                {
                    FBOL.Mobile.Entityframework.DTO.User user = _am.GetUser(userLogin.UserName.Trim());

                    if (user.IsActive && user.IsConfirmed)
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        private string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
       
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Audience"],
              claims,
              expires: DateTime.Now.AddMinutes(20),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpGet]
        [Authorize]
        public IActionResult UserEndpoint()
        {
            var currentUser = GetCurrentUser();

            return Ok($"Hi {currentUser.UserId}, you are logged in");
        }


        [HttpGet]
        public IActionResult test()
        {
            var currentUser = GetCurrentUser();
            var dic = new Dictionary<string, object>();
            dic.Add("activity", new ActivityResponse { ActivityTitle = "dfsdfg" });
            dic.Add("participant", new ActivityRequest { activityId = 2131231 });
            return Ok(dic);
        }



        private User GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;

                return new User
                {
                    UserId =  int.TryParse(userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value, out var id) ? id : 0
                };
            }
            return null;
        }
    }
}
/*new Claim(ClaimTypes.Email, user.EmailAddress),
       new Claim(ClaimTypes.GivenName, user.GivenName),
       new Claim(ClaimTypes.Surname, user.Surname),
       new Claim(ClaimTypes.Role, user.Role)*/