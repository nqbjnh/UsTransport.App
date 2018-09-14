using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsTransport.Checking.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            //MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            MasterPage.ListView.ItemTapped += ListView_ItemTapped;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (!(e.Item is MainPageMenuItem item))
                return;

            if (item.Id == 10) // logout
            {
                var result = await DisplayAlert("Đăng xuất", "Bạn có muốn đăng xuất tài khoản ?", "Có", "Không"); // since we are using async, we should specify the DisplayAlert as awaiting.
                if (result) // if it's equal to Ok
                {
                    //delete database
                    await App.IEFSERVICE.DeleteUserAsync(App.USER);
                    Application.Current.MainPage = new Login();
                }
                return;
            }

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            if (item.TargetType == typeof(ScanPage))
            {
                page.BindingContext = item;
            }

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }

       
    }
}