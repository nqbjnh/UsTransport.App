using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UsTransport.Checking.Models;
using UsTransport.Checking.Utils;

namespace UsTransport.Checking.Services
{
    public class StoreService: IStoreService
    {
        public Task<ObservableCollection<Store>> GetStoresAsync()
        {
            try
            {
                var stores = Client.PostAsync<ObservableCollection<Store>>("http://api-ustransport.tinchat.net/api/app/store/getall", "");
                return stores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}