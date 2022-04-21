using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CertificateIssued
    {
        public int Id { get; set; }
        public int? ParticipantId { get; set; }
        public DateTime? CertificateIssuedDate { get; set; }
        public string CertType { get; set; }
        public string Competencies { get; set; }
        public int? QualificationId { get; set; }
        public string CertificateNo { get; set; }
        public bool? Completed { get; set; }
        public int? Text1 { get; set; }
        public int? Text2 { get; set; }
        public int? Text3 { get; set; }
        public int? Text4 { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
