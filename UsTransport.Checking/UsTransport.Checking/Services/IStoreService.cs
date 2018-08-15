using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UsTransport.Checking.Models;

namespace UsTransport.Checking.Services
{
    public interface IStoreService
    {
        Task<ObservableCollection<Store>> GetStoresAsync();
    }
}