namespace UsTransport.Checking.Models
{
    public class StoreWithPackageViewDTO
    {
        public int StoreId { get; set; }
        public int WarehouseId { get; set; }
        public string StoreName { get; set; }
        public int TotalPackageNew { get; set; }
        public int TotalPakkageSendToVn { get; set; }
        public int TotalPackagePickedUp { get; set; }
        public int StatusNew { get; set; }
        public int StatusPickedUp { get; set; }
        public int StatusSendToVn { get; set; }
        public string StatusNewColor => "#" + (EOrderStatus.New.ToString().GetHashCode() & 0x00FFFFFF).ToString("X6");
        public string StatusPickedUpColor => "#" + (EOrderStatus.PickedUp.ToString().GetHashCode() & 0x00FFFFFF).ToString("X6");
        public string StatusSendToVnColor => "#" + (EOrderStatus.SendToVN.ToString().GetHashCode() & 0x00FFFFFF).ToString("X6");

        public PackageSearchFromApp AllPackageSearch => new PackageSearchFromApp()
        {
            StoreId = StoreId,
            WarehouseId = WarehouseId,
            StoreName = StoreName
        };

        public PackageSearchFromApp NewPackageSearch => new PackageSearchFromApp()
        {
            StoreId = StoreId,
            WarehouseId = WarehouseId,
            StatusId = StatusNew,
            StoreName = StoreName
        };

        public PackageSearchFromApp PickupPackageSearch => new PackageSearchFromApp()
        {
            StoreId = StoreId,
            WarehouseId = WarehouseId,
            StatusId = StatusPickedUp,
            StoreName = StoreName
        };
        public PackageSearchFromApp SendToVnPackageSearch => new PackageSearchFromApp()
        {
            StoreId = StoreId,
            WarehouseId = WarehouseId,
            StatusId = StatusSendToVn,
            StoreName = StoreName
        };


    }
}