using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UsTransport.Checking.Models;

namespace UsTransport.Checking.Services
{
    public interface IStoreService
    {
        Task<ObservableCollection<PackageViewDTO>> GetStoresAsync(PackageSearchFromApp packageSearchFromApp);
        Task<Response> GetOrderByCodeAsync(string OrderCode);
        Task<Response> UpdateOrderStatus(int PackageId, int CurrentStatus, int UpdateStatus);

    }
}