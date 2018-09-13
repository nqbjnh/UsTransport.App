using System.Collections.Generic;

namespace UsTransport.Checking.Models
{
    public class PackageViewDTO
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public int StatusId { get; set; }
        public string OrderCode { get; set; }
        public string FullName { get; set; }
        public int TotalItems { get; set; }
        public int Ordinal { get; set; }
        public string Code { get; set; }
        public decimal Weight { get; set; }
        public string CreateDate { get; set; }
        public string PickupDate { get; set; }
        public string ShippingDate { get; set; }
        public string ClearCustomDate { get; set; }
        public string DeliverName { get; set; }
        public string StatusName { get; set; }
        /// <summary>
        /// same AirPort in tblOrder
        /// </summary>
        public string Destination { get; set; }
        public string Tracking { get; set; }
        public long CreateTime { get; set; }
        public long PickupTime { get; set; }
        public long ShippingTime { get; set; }
        public long ClearCustomTime { get; set; }
        public long DeliverTime { get; set; }

        public string StoreName { get; set; }
        public List<ItemPackageViewDTO> Items { get; set; }

        public string StatusNameColor => "#" + (StatusName.GetHashCode() & 0x00FFFFFF).ToString("X6");

    }
}