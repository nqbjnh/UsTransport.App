using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UsTransport.Checking.Models;

namespace UsTransport.Checking.Services
{
    public interface IStoreService
    {
        Task<ObservableCollection<Store>> GetStoresAsync();
        Task<Response> GetOrderByCodeAsync(string OrderCode);
        Task<Response> UpdateOrderStatus(string OrderCode,int Status);

    }
}