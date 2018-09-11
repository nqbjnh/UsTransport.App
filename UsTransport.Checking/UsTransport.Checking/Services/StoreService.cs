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
        public Task<ObservableCollection<PackageViewDTO>> GetStoresAsync(PackageSearchFromApp packageSearchFromApp)
        {
            try
            {
                var response = Client.PostAsync<Response>(App.APPCONFIG.Api + "/api/app/store/getall", packageSearchFromApp.ToJson()).Result;
                if (response.Code == 0)
                {
                    return Task.FromResult(response.Data.ToString().JsonToObject<ObservableCollection<PackageViewDTO>>());
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
                return Task.FromResult(Client.PostAsync<Response>(App.APPCONFIG.Api + "/api/app/store/order/getbycode", new {Code = OrderCode}.ToJson()).Result);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Response> UpdateOrderStatus(int PackageId,int CurrentStatus,int UpdateStatus)
        {
            try
            {
                return Task.FromResult(Client.PostAsync<Response>(App.APPCONFIG.Api + "/api/app/store/order/updatestatus", new { PackageId = PackageId, CurrentStatus = CurrentStatus, UpdateStatus = UpdateStatus }.ToJson()).Result);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}