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
        public Task<ObservableCollection<StoreWithPackageViewDTO>> GetStoresAsync(PackageSearchFromApp packageSearchFromApp)
        {
            try
            {
                var response = Client.PostByTokenAsync<Response>(App.APPCONFIG.Api + "/api/app/store/getall", packageSearchFromApp.ToJson()).Result;
                if (response.Code == 0)
                {
                    return Task.FromResult(response.Data.ToString().JsonToObject<ObservableCollection<StoreWithPackageViewDTO>>());
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<ObservableCollection<PackageViewDTO>> GetPackageAsync(PackageSearchFromApp packageSearchFromApp)
        {
            try
            {
                var response = Client.PostByTokenAsync<Response>(App.APPCONFIG.Api + "/api/app/store/getpackage", packageSearchFromApp.ToJson()).Result;
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

        public Task<Response> GetPackageByCodeAsync(string OrderCode)
        {
            try
            {
                return Task.FromResult(Client.PostByTokenAsync<Response>(App.APPCONFIG.Api + "/api/app/store/order/getbycode", new {Code = OrderCode}.ToJson()).Result);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Response> UpdatePackageStatus(int PackageId,int UpdateStatus)
        {
            try
            {
                return Task.FromResult(Client.PostByTokenAsync<Response>(App.APPCONFIG.Api + "/api/app/store/order/updatestatus", new { PackageId = PackageId, UpdateStatus = UpdateStatus,AppTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") }.ToJson()).Result);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}