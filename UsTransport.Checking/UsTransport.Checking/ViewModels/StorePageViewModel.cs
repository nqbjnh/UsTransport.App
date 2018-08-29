using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using UsTransport.Checking.Models;
using UsTransport.Checking.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace UsTransport.Checking.ViewModels
{
    public class StorePageViewModel :BaseViewModel
    {
        public ObservableCollection<PackageViewDTO> _Stores { get; set; }

        public ObservableCollection<PackageViewDTO> Stores
        {
            get { return _Stores; }
            set
            {
                _Stores = value;
                OnPropertyChanged();
            }
        }
        public Command LoadStoresCommand { get; set; }
        public ICommand ItemAppearingCommand => new Command(ItemAppearingAsync);
        public IStoreService _IStoreService;
        public PackageSearchFromApp _PackageSearchFromApp;
        public StorePageViewModel()
        {
            _IStoreService = new StoreService();
            Stores = new ObservableCollection<PackageViewDTO>();
            LoadStoresCommand = new Command(async () => await ExecuteLoadStoresCommand());
            
        }

        private async void ItemAppearingAsync()
        {
            _PackageSearchFromApp.PageIndex++;
            var stores = await _IStoreService.GetStoresAsync(_PackageSearchFromApp);
            stores.ForEach(x =>
            {
                x.StatusNameColor = "#" + (x.StatusName.GetHashCode() & 0x00FFFFFF).ToString("X6");
                Stores.Add(x);
            }); //get color by status name

        }

        async Task ExecuteLoadStoresCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Stores.Clear();
                _PackageSearchFromApp = new PackageSearchFromApp();
                Stores = await _IStoreService.GetStoresAsync(_PackageSearchFromApp);
                Stores.ForEach(x=>x.StatusNameColor = "#"+(x.StatusName.GetHashCode() & 0x00FFFFFF).ToString("X6")); //get color by status name

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

        public void Search(string StoreName)
        {
            try
            {
                Stores.Clear();
                _PackageSearchFromApp = new PackageSearchFromApp
                {
                    StoreName = StoreName
                };
                Stores =  _IStoreService.GetStoresAsync(_PackageSearchFromApp).Result;
                Stores.ForEach(x => x.StatusNameColor = "#" + (x.StatusName.GetHashCode() & 0x00FFFFFF).ToString("X6")); //get color by status name
               
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