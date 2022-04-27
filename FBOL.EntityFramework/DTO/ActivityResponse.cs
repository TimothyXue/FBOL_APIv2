namespace FBOL.EntityFramework.DTO
{
    public class ActivityResponse
    {
        public int ActivityId { get; set; }
        public string ActivityTitle { get; set; }
        public string ActivityDesc { get; set; }
        public string XslTemplate { get; set; }
        public string PdfTemplate { get; set; }
        public string ActivityText { get; set; }
        public bool? Tool { get; set; }
        public string Url { get; set; }
        public int? AutoAssess { get; set; }
        public int? Alternative { get; set; }
        public bool? MmAssessed { get; set; }
        public string ActivityPlatform { get; set; }
        public string ActivityXml { get; set; }
        public string ActivityXmlBackup { get; set; }
        public int? AssessmentMethodId { get; set; }
        public bool MmActivity { get; set; }
        public short? HiddenFromParticipant { get; set; }
        public string AnwserXml { get; set; }
    }
}
