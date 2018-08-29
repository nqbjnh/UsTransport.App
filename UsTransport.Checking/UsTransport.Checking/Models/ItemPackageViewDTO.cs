namespace UsTransport.Checking.Models
{
    public class ItemPackageViewDTO
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; }

    }
}