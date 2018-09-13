using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using UsTransport.Checking.Models;
using UsTransport.Checking.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsTransport.Checking.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StorePage : ContentPage
    {
        private StorePageViewModel _storePageViewModel;
        public ObservableCollection<string> Items { get; set; }

        public StorePage()
        {
            InitializeComponent();
            BindingContext = _storePageViewModel = new StorePageViewModel(Navigation);

        }

        /* async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
         {
             if (e.Item == null)
                 return;

             await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

             //Deselect Item
             ((ListView)sender).SelectedItem = null;
         }*/

        /*async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var store = args.SelectedItem as Store;
            if (store == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(store)));

            // Manually deselect item.
            StoresListView.SelectedItem = null;
        }*/

        /*async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }*/

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (_storePageViewModel.Stores.Count == 0)
                _storePageViewModel.LoadStoresCommand.Execute(null);
        }



        private void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
        {
            try
            {
                var searchBar = sender as SearchBar;
                _storePageViewModel.Search(searchBar.Text.Trim());
            }
            catch (Exception)
            {
                
            }
        }

        /*private void StoresListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var storeItem = e.SelectedItem as StoreWithPackageViewDTO;
            _storePageViewModel.SearchStatusCommand.Execute(storeItem.AllPackageSearch);
        }*/

        private void StoresListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var storeItem = e.Item as StoreWithPackageViewDTO;
            _storePageViewModel.SearchStatusCommand.Execute(storeItem.AllPackageSearch);
        }
    }
}
