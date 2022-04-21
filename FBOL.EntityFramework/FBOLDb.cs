using FBOL.EntityFramework.DTO;
using FBOL.EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOL.EntityFramework
{
    public  class FBOLDb
    {
        public static DTO.LessonGroup GetLessonGroupByLessonGroupID(int lessonGroupId)
        {
            using (FBOLContext ctx = new FBOLContext())
            {

                Model.LessonGroup lsg = ctx.LessonGroups.Where(x => (x.LessonGroupId == lessonGroupId)).FirstOrDefault();

                return FBOLDtoConvertor.ConvertToDto(lsg);

            }
        }
    }
}
