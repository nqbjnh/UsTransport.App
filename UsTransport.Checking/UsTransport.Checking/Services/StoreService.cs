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
                var response = Client.PostAsync<Response>("http://api-ustransport.tinchat.net/api/app/store/getall", "").Result;
                if (response.Code == 0)
                {
                    return Task.FromResult(response.Data.ToString().JsonToObject<ObservableCollection<Store>>());
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Response> GetOrderByCodeAsync(string OrderCode)
        {
            try
            {
                return Task.FromResult(Client.PostAsync<Response>("http://api-ustransport.tinchat.net/api/app/store/order/getbycode", new {OrderCode = OrderCode}.ToJson()).Result);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Response> UpdateOrderStatus(string OrderCode,int Status)
        {
            try
            {
                return Task.FromResult(Client.PostAsync<Response>("http://api-ustransport.tinchat.net/api/app/store/order/updatestatus", new { OrderCode = OrderCode,Status = Status }.ToJson()).Result);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}