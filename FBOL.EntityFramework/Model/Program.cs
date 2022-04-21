using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class Program
    {
        public Program()
        {
            Enrollees = new HashSet<Enrollee>();
        }

        public int ProgramId { get; set; }
        public DateTime? OverviewDate { get; set; }
        public bool InHouse { get; set; }
        public int CourseId { get; set; }
        public int? FacilitatorUserId { get; set; }
        public int? CoFacilitatorUserId { get; set; }
        public string ObserverType { get; set; }
        public int? Observer2UserId { get; set; }
        public string Observer2Type { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string StateCode { get; set; }
        public DateTime? GraduationDate { get; set; }
        public string Notes { get; set; }
        public bool? IsConfirmed { get; set; }
        public string Facilitator { get; set; }
        public string Cofacilitator { get; set; }
        public bool? DisableEmail { get; set; }
        public int? LicenseeId { get; set; }
        public int? OnlineModules { get; set; }
        public string AddressFup { get; set; }
        public decimal? RoomHireCosts { get; set; }
        public int? NumberOfModules { get; set; }
        public decimal? CateringCosts { get; set; }
        public decimal? OtherCosts { get; set; }
        public string DetailsOfOthers { get; set; }
        public int? FacFee { get; set; }
        public int? PartFirstPay { get; set; }
        public int? PartSecondPay { get; set; }
        public string MapName { get; set; }
        public int? OldLicenseeId { get; set; }
        public bool? PdpDias { get; set; }
        public bool? QiSurvey { get; set; }
        public short? MappingId { get; set; }
        public int? AlVersion { get; set; }
        public int? LocationId { get; set; }
        public string PostCode { get; set; }
        public string Suburb { get; set; }
        public string LocationNote { get; set; }
        public bool? DisplayLocationNote { get; set; }
        public decimal? OtherCostsMcr { get; set; }
        public string DetailsOfOthersMcr { get; set; }
        public short? TableSize { get; set; }
        public DateTime? CertificateCreated { get; set; }
        public int? PpbId { get; set; }
        public string BuildingName { get; set; }
        public string UnitDetails { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? TotalRoomHire { get; set; }
        public DateTime? LatestAssessmentDueDateCalculatedAkaPst { get; set; }
        public bool? IsDualQual { get; set; }
        public bool? MmOrObserverUnitSignoffReq { get; set; }
        public DateTime? CertGivenEmailDate { get; set; }
        public bool? IsVirtual { get; set; }
        public bool? NotAccredited { get; set; }

        public virtual ProgramApproval ProgramApproval { get; set; }
        public virtual ICollection<Enrollee> Enrollees { get; set; }
    }
}
