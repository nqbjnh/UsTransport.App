using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using UsTransport.Checking.Models;
using UsTransport.Checking.Services;
using UsTransport.Checking.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace UsTransport.Checking.ViewModels
{
    public class StorePageViewModel :BaseViewModel
    {
        public ObservableCollection<StoreWithPackageViewDTO> _Stores { get; set; }

        public ObservableCollection<StoreWithPackageViewDTO> Stores
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
        public ICommand SearchStatusCommand => new Command<PackageSearchFromApp>(SearchByStatus);

        

        public IStoreService _IStoreService;
        public PackageSearchFromApp _PackageSearchFromApp;

        private INavigation _iNavigation;
        public StorePageViewModel(INavigation navigation)
        {
            _IStoreService = new StoreService();
            Stores = new ObservableCollection<StoreWithPackageViewDTO>();
            LoadStoresCommand = new Command(async () => await ExecuteLoadStoresCommand());
            _iNavigation = navigation;
        }

        private async void SearchByStatus(PackageSearchFromApp packageSearchFromApp)
        {
            packageSearchFromApp.UserId = App.USER.UserId;

            var packagePage = new PackagePage(packageSearchFromApp)
            {
                Title = packageSearchFromApp.StoreName
            };
            await _iNavigation.PushAsync(packagePage);
        }

        private async void ItemAppearingAsync()
        {
            _PackageSearchFromApp.PageIndex++;
            var stores = await _IStoreService.GetStoresAsync(_PackageSearchFromApp);
            stores.ForEach(x =>
            {
               Stores.Add(x);
            });

        }


        async Task ExecuteLoadStoresCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Stores.Clear();
                _PackageSearchFromApp = new PackageSearchFromApp(){UserId = App.USER.UserId};
                Stores = await _IStoreService.GetStoresAsync(_PackageSearchFromApp);

               /* Stores.ForEach(x=>x.StatusNameColor = "#"+(x.StatusName.GetHashCode() & 0x00FFFFFF).ToString("X6")); //get color by status name*/

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
                    StoreName = StoreName,
                    UserId = App.USER.UserId
                };
                Stores =  _IStoreService.GetStoresAsync(_PackageSearchFromApp).Result;
                /*Stores.ForEach(x => x.StatusNameColor = "#" + (x.StatusName.GetHashCode() & 0x00FFFFFF).ToString("X6")); //get color by status name*/
               
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