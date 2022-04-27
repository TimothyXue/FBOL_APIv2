
using FBOL.EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.EntityFramework
{
    internal class FBOLDtoConvertor
    {
        public static EntityFramework.DTO.LessonGroup ConvertToDto(LessonGroup entity)
        {
            if (entity == null)
            {
                return null;
            }

            EntityFramework.DTO.LessonGroup dto = new EntityFramework.DTO.LessonGroup()
            {
                LessonGroupId =entity.LessonGroupId,
                CourseId =entity.CourseId,
                GroupId =entity.GroupId,
                GroupSeq =entity.GroupSeq,
                LessonId =entity.LessonId,
                LessonSeq=entity.LessonSeq,
                lesson_group_name = entity.lesson_group_name
            };

            return dto;
        }
        public static EntityFramework.DTO.Lesson ConvertToDto(Lesson entity)
        {
            if (entity == null)
            {
                return null;
            }

            EntityFramework.DTO.Lesson dto = new EntityFramework.DTO.Lesson()
            {
                CourseId = entity.CourseId,
                LessonId = entity.LessonId,
                LessonSeq = entity.LessonSeq,
                LessonName=entity.LessonName,
                LessonTitle= entity.LessonTitle,
                LearningOutcomeTitle= entity.LearningOutcomeTitle,
                FmiElementId=entity.FmiElementId,
                AssignmentEmail=entity.AssignmentEmail,
                LessonDuration=entity.LessonDuration,
                DaysSincePrevLesson=entity.DaysSincePrevLesson,
                Extras=entity.Extras,
                FacBill1=entity.FacBill1,
                FacBill2=entity.FacBill2,
                LeadDiscussion=entity.LeadDiscussion,
                CoursePart=entity.CoursePart,
                TeamView2=  entity.TeamView2,
                FirstLesson=    entity.FirstLesson,
                LastLesson= entity.LastLesson
                
            };

            return dto;
        }
        public static EntityFramework.DTO.Activity ConvertToDto(Activity entity)
        {
            if (entity == null)
            {
                return null;
            }

            EntityFramework.DTO.Activity dto = new EntityFramework.DTO.Activity()
            {
                ActivityId= entity.ActivityId,
                ActivityTitle= entity.ActivityTitle,
                ActivityDesc= entity.ActivityDesc,
                XslTemplate= entity.XslTemplate,
                PdfTemplate= entity.PdfTemplate,
                ActivityText= entity.ActivityText,
                Tool= entity.Tool,
                Url= entity.Url,
                AutoAssess= entity.AutoAssess,
                Alternative= entity.Alternative,
                MmAssessed= entity.MmAssessed,
                ActivityPlatform= entity.ActivityPlatform,
                ActivityXml= entity.ActivityXml,
                ActivityXmlBackup= entity.ActivityXmlBackup,
                AssessmentMethodId= entity.AssessmentMethodId,
                MmActivity= entity.MmActivity,
                HiddenFromParticipant= entity.HiddenFromParticipant
            };

            return dto;
        }


        public static EntityFramework.DTO.ActivityDetail ConvertToDto(ActivityDetail entity)
        {
            if (entity == null)
            {
                return null;
            }

            EntityFramework.DTO.ActivityDetail dto = new EntityFramework.DTO.ActivityDetail()
            {
               ActivityDetailId= entity.ActivityDetailId,
               ActivityId = entity.ActivityId,
               ParticipantId = entity.ParticipantId,
               ActivityDate = entity.ActivityDate,
               XmlTemplate = entity.XmlTemplate,
               Paper= entity.Paper,
               Completed= entity.Completed,
               Assessed= entity.Assessed,
               Status = entity.Status,
               WorkareaUrl= entity.WorkareaUrl,
               SubmitToMm= entity.SubmitToMm,
               XmlActivityData= entity.XmlActivityData,
               XmlActivityDataBackup= entity.XmlActivityDataBackup,
               ReviewerParticipantId= entity.ReviewerParticipantId
            };

            return dto;
        }



    }
}
