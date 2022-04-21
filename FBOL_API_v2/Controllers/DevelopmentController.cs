using FBOL.EntityFramework;
using FBOL.Mobile.Entityframework.DTO;
using FBOL_API_v2.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace FBOL_API_v2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class DevelopmentController : Controller
    {
        private readonly ILogger<DevelopmentController> _logger;

        public DevelopmentController(ILogger<DevelopmentController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult GetLessonGroup(LessonGroupRequest request)
        {
            

            try
            {
                var lsg = FBOLDb.GetLessonGroupByLessonGroupID(request.LessonGroupId);
                if (lsg == null) 
                {
                    return NotFound("Lesson not found");
                }
                else
                {
                    return Ok(lsg);
                }
            }
            catch (Exception)
            {

                return NotFound("Lesson not found");
            }
        }
        private User GetCurrentUserName()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;

                return new User
                {
                    UserName = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                };
            }
            return null;
        }
    }
}

   

