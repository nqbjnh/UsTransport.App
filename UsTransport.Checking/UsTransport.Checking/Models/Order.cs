using System;

namespace UsTransport.Checking.Models
{
    public class Order
    {
        public string Code { get; set; }
        public int TotalPackage { get; set; }
        public float Weight { get; set; }   
        public float TotalCharge { get; set; }   
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
        public int StoreId { get; set; }

    }
}