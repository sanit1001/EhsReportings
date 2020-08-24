using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClientContractPerRrfacility
    {
        public int Idclient { get; set; }
        public string ClientName { get; set; }
        public string ServiceCode { get; set; }
        public string HeadingSetName { get; set; }
        public DateTime? StartOfDelivery { get; set; }
        public DateTime? EndOfDelivery { get; set; }
        public string ClientLongName { get; set; }
        public string UseSnapshotDb { get; set; }
        public string LnamePerson { get; set; }
        public string FnamePerson { get; set; }
        public bool GetsHelpLine { get; set; }
        public string DistributionNote { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string RegionCode { get; set; }
        public string Region { get; set; }
        public string LanguageCode { get; set; }
        public bool WebDelivery { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IncludeEnglish { get; set; }
        public bool IncludeFields { get; set; }
        public bool IncludeFederal { get; set; }
        public bool? IncludeGenericIndustry { get; set; }
        public bool? IsForOffices { get; set; }
        public bool? IsForWareHouses { get; set; }
        public int? IndustrySector { get; set; }
        public string MasterCountryCode { get; set; }
        public string MasterRegionCode { get; set; }
        public bool IsRto { get; set; }
        public bool HasMappedHeadings { get; set; }
        public string Name { get; set; }
        public string FacilityCode { get; set; }
        public DateTime FacilityCreateDate { get; set; }
        public DateTime FacilityLastModifiedDate { get; set; }
        public int Status { get; set; }
        public string ContractedForService { get; set; }
    }
}
