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
    public class PackagePageViewModel : BaseViewModel
    {
        public ObservableCollection<PackageViewDTO> _Packages { get; set; }

        public ObservableCollection<PackageViewDTO> Packages
        {
            get { return _Packages; }
            set
            {
                _Packages = value;
                OnPropertyChanged();
            }
        }
        public Command LoadPackagesCommand { get; set; }
        public ICommand ItemAppearingCommand => new Command(ItemAppearingAsync);



        public IStoreService _IStoreService;
        public PackageSearchFromApp _PackageSearchFromApp;
        private INavigation _iNavigation;

        public PackagePageViewModel(PackageSearchFromApp packageSearchFromApp,INavigation iNavigation)
        {
            _IStoreService = new StoreService();
            Packages = new ObservableCollection<PackageViewDTO>();
            LoadPackagesCommand = new Command(async () => await ExecuteLoadPackagesCommand());
            _PackageSearchFromApp = packageSearchFromApp;
            _iNavigation = iNavigation;
        }

        public async void GetPackageDetail(string PackageCode)
        {

            var itemPage = new ItemPage(PackageCode)
            {
                Title = PackageCode
            };
            await _iNavigation.PushAsync(itemPage);
        }

        private async void ItemAppearingAsync()
        {
            _PackageSearchFromApp.PageIndex++;
            var packages = await _IStoreService.GetPackageAsync(_PackageSearchFromApp);
            packages.ForEach(x =>
            {
                Packages.Add(x);
            });

        }

        async Task ExecuteLoadPackagesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Packages.Clear();
                _PackageSearchFromApp.PageIndex = 1;
                Packages = await _IStoreService.GetPackageAsync(_PackageSearchFromApp);

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

        /*public void Search(string StoreName)
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
                /*Stores.ForEach(x => x.StatusNameColor = "#" + (x.StatusName.GetHashCode() & 0x00FFFFFF).ToString("X6")); //get color by status name#1#
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }*/
    }
}