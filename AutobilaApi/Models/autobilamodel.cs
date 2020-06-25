using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutobilaApi.Models
{
    public class AutoAttachments
    {
        public int Id { get; set; }
        public int AutoInfoId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileContent { get; set; }
        public string FileDesc { get; set; }
        public string FilePath { get; set; }
        public string FolderPath { get; set; }
    }
    public class AutoFeatures
    {
        public Int64 Id { get; set; }
        public int AutoMakeId { get; set; }
        public int AutoModelId { get; set; }
        public string InteriorDesign { get; set; }
        public string SpecialFeatures { get; set; }
        public string ExteriorFeatures { get; set; }
        public string SecurityEnvironment { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string ModelDescription { get; set; }
    }
    public class AutoInfoMaster
    {
        public int Id { get; set; }
        public int AutoDealerId { get; set; }
        public string AutoDealerName { get; set; }
        public string AutoName { get; set; }
        public string AutoDescription { get; set; }
        public string AutoLocation { get; set; }
        public string AutoMake { get; set; }
        public string AutoModel { get; set; }
        public string Price { get; set; }
        public int Year { get; set; }
        public int Kilometers { get; set; }
        public string AutoType { get; set; }
        public string Color { get; set; }
        public string InteriorColor { get; set; }
        public string GearBox { get; set; }
        public int Seats { get; set; }
        public string Specs { get; set; }
        public int Doors { get; set; }
        public int Cylinders { get; set; }
        public int Wheels { get; set; }
        public string FuelType { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public string FirstImage { get; set; }
        public string DealerImage { get; set; }
        public string AutoFeatures { get; set; }
        public string AutoLatitude { get; set; }
        public string AutoLongitude { get; set; }
        public int AutoMakeId { get; set; }
        public string Comments { get; set; }
        public int AutoModelId { get; set; }
        public string AutoFolderPath { get; set; }
        public string Condition { get; set; }
        public int AutoTypeId { get; set; }
        
    }
    public class AutoMakeMaster
    {
        public int Id { get; set; }
        public string AutoMakeName { get; set; }
        public string AutoMakeCode { get; set; }
        public string AutoMakeDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
    public class AutoModelMaster
    {
        public int Id { get; set; }
        public int AutoMakeMasterId { get; set; }
        public string AutoModelName { get; set; }
        public string AutoModelCode { get; set; }
        public string AutoModelDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
    public class AutoTypeMaster
    {
        public int Id { get; set; }
        public string AutoTypeName { get; set; }
        public string AutoTypeCode { get; set; }
        public string AutoTypeDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
    public class DealerAttachments
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileContent { get; set; }
        public string FileDesc { get; set; }
        public string FilePath { get; set; }
        public int DealerInfoId { get; set; }
    }
    public class DealersInfoMaster
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string TradeLicense { get; set; }
        public string Password { get; set; }
        public string DealerImage { get; set; }
        public string Comments { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsConfirm { get; set; }
    }
    public class YearMaster
    {
        public int Id { get; set; }
        public int Year { get; set; }
    }
    public class ColorMaster
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}