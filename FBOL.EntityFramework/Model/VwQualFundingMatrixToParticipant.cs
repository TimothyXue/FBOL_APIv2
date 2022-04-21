﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class VwQualFundingMatrixToParticipant
    {
        public string StateCode { get; set; }
        public int QualStateFundingId { get; set; }
        public int QualificationId { get; set; }
        public int CourseId { get; set; }
        public int FundingTypeId { get; set; }
        public byte QualOrderId { get; set; }
        public byte? LocaleId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int ParticipantId { get; set; }
        public byte Expr1 { get; set; }
    }
}
