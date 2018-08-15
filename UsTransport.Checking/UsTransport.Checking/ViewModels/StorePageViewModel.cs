using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using UsTransport.Checking.Models;
using UsTransport.Checking.Services;
using Xamarin.Forms;

namespace UsTransport.Checking.ViewModels
{
    public class StorePageViewModel :BaseViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }
        public Command LoadStoresCommand { get; set; }
        public IStoreService _IStoreService;
        public StorePageViewModel()
        {
            Stores = new ObservableCollection<Store>();
            LoadStoresCommand = new Command(async () => await ExecuteLoadStoresCommand());
        }

        async Task ExecuteLoadStoresCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Stores.Clear();
                Stores = await _IStoreService.GetStoresAsync();
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}