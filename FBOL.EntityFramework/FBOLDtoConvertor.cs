
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
            };

            return dto;
        }

    }
}
