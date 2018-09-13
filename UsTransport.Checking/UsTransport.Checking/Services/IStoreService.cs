using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UsTransport.Checking.Models;

namespace UsTransport.Checking.Services
{
    public interface IStoreService
    {
        Task<ObservableCollection<StoreWithPackageViewDTO>> GetStoresAsync(PackageSearchFromApp packageSearchFromApp);
        Task<ObservableCollection<PackageViewDTO>> GetPackageAsync(PackageSearchFromApp packageSearchFromApp);
        Task<Response> GetPackageByCodeAsync(string OrderCode);
        Task<Response> UpdatePackageStatus(int PackageId, int UpdateStatus);

    }
}