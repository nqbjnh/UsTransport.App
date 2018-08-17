using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UsTransport.Checking.Models;
using UsTransport.Checking.Services;
using Xamarin.Forms;

namespace UsTransport.Checking.ViewModels
{
    public class StorePageViewModel :BaseViewModel
    {
        public ObservableCollection<Store> _Stores { get; set; }

        public ObservableCollection<Store> Stores
        {
            get { return _Stores; }
            set
            {
                _Stores = value;
                OnPropertyChanged();
            }
        }
        public Command LoadStoresCommand { get; set; }
        public IStoreService _IStoreService;
        public StorePageViewModel()
        {
            _IStoreService = new StoreService();
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
                
                /*foreach (var item in data)
                {
                    
                    Stores.Add(item);
                }*/
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