using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using UsTransport.Checking.Models;
using UsTransport.Checking.Services;
using UsTransport.Checking.Utils;
using UsTransport.Checking.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace UsTransport.Checking.ViewModels
{
    public class ItemPageViewModel :BaseViewModel
    {
        public PackageViewDTO _PackageDetail { get; set; }

        public PackageViewDTO PackageDetail
        {
            get { return _PackageDetail; }
            set
            {
                _PackageDetail = value;
                OnPropertyChanged();
            }
        }
        //public Command LoadItemCommand { get; set; }
        

        public IStoreService _IStoreService;
        
        public ItemPageViewModel()
        {
            _IStoreService = new StoreService();
            //PackageDetail = new PackageViewDTO();
        }


        public void ExecuteLoadItemCommand(string PackageCode)
        {

            try
            {
                var result = _IStoreService.GetPackageByCodeAsync(PackageCode).Result;
                if (result.Code == Error.SUCCESS.Code)
                {
                    PackageDetail = result.Data.ToJson().JsonToObject<PackageViewDTO>();
                   
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

       
    }
}