﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwParticipantCompetencyUnitCountByParticipantQualificationId
    {
        public int ParticipantId { get; set; }
        public int QualificationId { get; set; }
        public int? PartQualUnitCount { get; set; }
    }
}
