using FBOL.EntityFramework.DTO;
using FBOL.EntityFramework.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.EntityFramework
{
    public  class FBOLDb
    {
        private readonly IConfiguration _config;

        public FBOLDb(IConfiguration config)
        {
            _config = config;
        }

        public  DTO.LessonGroup GetLessonGroupByLessonGroupID(int lessonGroupId)
        {
            using (FBOLContext ctx = new FBOLContext(_config))
            {

                Model.LessonGroup lsg = ctx.LessonGroups.Where(x => (x.LessonGroupId == lessonGroupId)).FirstOrDefault();

                return FBOLDtoConvertor.ConvertToDto(lsg);

            }
        }

        public  object GetLessonByLessonID(int lessonId)
        {
            using (FBOLContext ctx = new FBOLContext(_config))
            {

                Model.Lesson ls = ctx.Lessons.Where(x => (x.LessonId == lessonId)).FirstOrDefault();

                return FBOLDtoConvertor.ConvertToDto(ls);

            }
        }

        public  object GetActivityByActivityID(int activityId)
        {
            using (FBOLContext ctx = new FBOLContext(_config))
            {

                Model.Activity ac = ctx.Activities.Where(x => (x.ActivityId == activityId)).FirstOrDefault();

                return FBOLDtoConvertor.ConvertToDto(ac);

            }
        }


        public List<ActivityResponse> GetActivityDetailsForActivittyListByParticipantID(IEnumerable<DTO.Activity> activities, IEnumerable< int> participantIds)
        {
           
            using (FBOLContext ctx = new FBOLContext(_config))
            {
                List<ActivityResponse> responses = new List<ActivityResponse>();
                int ii = participantIds.Count();
                try
                {
                    foreach (var item in activities)
                    {
                        Model.ActivityDetail acd = null;
                        foreach (var id in participantIds)
                        {
                            if (ctx.ActivityDetails.Where(x => (x.ActivityId == item.ActivityId && x.ParticipantId == id)).FirstOrDefault() != null)
                            {
                                acd = ctx.ActivityDetails.Where(x => (x.ActivityId == item.ActivityId && x.ParticipantId == id)).FirstOrDefault();
                            }
                        }

                        responses.Add(new ActivityResponse
                        {
                            ActivityId = item.ActivityId,
                            ActivityTitle = item.ActivityTitle,
                            ActivityDesc = item.ActivityDesc,
                            XslTemplate = item.XslTemplate,
                            ActivityXml = item.ActivityXml,
                            AnwserXml = acd.XmlActivityData
                        });
                    }

                    return responses;
                }
                catch (Exception)
                {
                    return responses;
                }
                

            }
        }


        public  List<DTO.Activity> GetActivitiesByActivityID(int lessonId)
        {

            using (FBOLContext ctx = new FBOLContext(_config))
            {
                List<ActivityLesson> ALlist = ctx.ActivityLessons.Where( x =>x.LessonId == lessonId).ToList();

                List<DTO.Activity> dtoAList = new List<DTO.Activity>();

                foreach (ActivityLesson item in ALlist)
                {
                    var ac = ctx.Activities.Where(x => (x.ActivityId == item.ActivityId)).FirstOrDefault();

                    dtoAList.Add( FBOLDtoConvertor.ConvertToDto(ac));
                }
                return dtoAList; 
            }
        }

        public  List<DTO.LessonGroup> GetLessonGroupsByCourseID(int CourseId)
        {

            using (FBOLContext ctx = new FBOLContext(_config))
            {
                List<Model.LessonGroup> LGList = ctx.LessonGroups.Where(x => x.CourseId == CourseId).ToList();

                List<DTO.LessonGroup> dtoLGList = new List<DTO.LessonGroup>();

                foreach (Model.LessonGroup item in LGList)
                {
                    var lg = ctx.LessonGroups.Where(x => (x.LessonGroupId == item.LessonGroupId)).FirstOrDefault();

                    dtoLGList.Add(FBOLDtoConvertor.ConvertToDto(lg));
                }

                return dtoLGList.OrderBy(m => m.GroupSeq).ToList();
            }
        }


        public  List<DTO.Lesson> GetLessonsByGroupID(int GroupId)
        {

            using (FBOLContext ctx = new FBOLContext(_config))
            {
                List<Model.LessonGroup> LGList = ctx.LessonGroups.Where(x => x.GroupId == GroupId).OrderBy(x=>x.GroupSeq).ToList();

                List<DTO.Lesson> dtoLList = new List<DTO.Lesson>();

                foreach (Model.LessonGroup item in LGList)
                {
                    var lg = ctx.Lessons.Where(x => (x.LessonId == item.LessonId)).FirstOrDefault();

                    dtoLList.Add(FBOLDtoConvertor.ConvertToDto(lg));
                }

                return dtoLList.OrderBy(m=>m.LessonSeq).ToList();
            }
        }

        public List<int> GetParticipantIDs(int UserID)
        {
            using (FBOLContext ctx = new FBOLContext(_config))
            {
                List<int> participantIDs = new List<int>();
                List<Model.Participant> participants = ctx.Participants.Where(x => (x.UserId == UserID)).ToList();
                foreach (var item in participants)
                {
                    participantIDs.Add(item.ParticipantId);
                }


                return participantIDs;

            }
        }
    }
}
