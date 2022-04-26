using FBOL.EntityFramework;
using FBOL.Mobile.Entityframework.DTO;
using FBOL_API_v2.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace FBOL_API_v2.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    [Authorize]
    public class DevelopmentController : Controller
    {
        private readonly ILogger<DevelopmentController> _logger;
        private readonly IConfiguration _config;
     
        public DevelopmentController(ILogger<DevelopmentController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpPost]
        public IActionResult GetLessonGroup(LessonGroupRequest request)
        {
            FBOLDb FBOLDb = new FBOLDb(_config);


            try
            {
                var lsg = FBOLDb.GetLessonGroupByLessonGroupID(request.LessonGroupId);
                if (lsg == null) 
                {
                    return NotFound("Lesson group not found");
                }
                else
                {
                    return Ok(lsg);
                }
            }
            catch (Exception)
            {

                return NotFound("Lesson group not found");
            }
        }


        [HttpPost]
        public IActionResult GetLesson(LessonRequest request)
        {
            FBOLDb FBOLDb = new FBOLDb(_config);
            try
            {
                var ls = FBOLDb.GetLessonByLessonID(request.LessonId);
                if (ls == null)
                {
                    return NotFound("Lesson not found");
                }
                else
                {
                    return Ok(ls);
                }
            }
            catch (Exception)
            {

                return NotFound("Lesson not found");
            }
        }

        [HttpPost]
        public IActionResult GetActivities(LessonRequest request)
        {
            FBOLDb FBOLDb = new FBOLDb(_config);
            try
            {
                var acs = FBOLDb.GetActivitiesByActivityID(request.LessonId);
                if (acs == null)
                {
                    return NotFound("Lessons not found");
                }
                else
                {
                    return Ok(acs);
                }
            }
            catch (Exception)
            {

                return NotFound("Lessons not found");
            }
        }


        [HttpPost]
        public IActionResult GetLessonGroups(LessonGroupsRequest request)
        {
            FBOLDb FBOLDb = new FBOLDb(_config);
            try
            {
                var lsg = FBOLDb.GetLessonGroupsByCourseID(request.CourseId);
                if (lsg == null)
                {
                    return NotFound("Lessons not found");
                }
                else
                {
                    return Ok(lsg);
                }
            }
            catch (Exception)
            {

                return NotFound("Lessons not found");
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

   

