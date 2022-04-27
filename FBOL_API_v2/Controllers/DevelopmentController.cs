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
        /* FOR TESTING THIS FUNCTION:
                SELECT ad.xml_activity_data, al.lesson_id FROM activity_detail ad join participant p on ad.participant_id = p.participant_id
        JOIN activity_lesson al on al.activity_id = ad.activity_id
        where ad.xml_activity_data is not null and p.user_id = 267
        */
        [HttpPost]
        public IActionResult GetParticipantActivities(LessonRequest request)
        {
            FBOLDb FBOLDb = new FBOLDb(_config);
            try
            {
              
               List<FBOL.EntityFramework.DTO.ActivityResponse> acd 
                    = FBOLDb.GetActivityDetailsForActivittyListByParticipantID(FBOLDb.GetActivitiesByActivityID(request.LessonId), FBOLDb.GetParticipantIDs(GetCurrentUser().UserId));
                if (acd == null || !acd.Any())
                {
                    return NotFound("Activities not found");
                }
                else
                {
                    return Ok(acd);
                }
            }
            catch (Exception)
            {

                return NotFound("Activities not found");
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


        private User GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;

                return new User
                {
                    UserId = int.TryParse(userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value, out var id) ? id : 0
                };
            }
            return null;
        }
    }
}

   

