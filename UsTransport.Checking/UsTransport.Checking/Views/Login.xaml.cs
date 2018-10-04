using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsTransport.Checking.Models;
using UsTransport.Checking.Services;
using UsTransport.Checking.Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsTransport.Checking.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		    pickerEnv.Items.Add("Môi trường thật");
		    pickerEnv.Items.Add("Môi trường test");
		    pickerEnv.SelectedIndex = 0;
		}

	    private async void BtnLogin_OnClicked(object sender, EventArgs e)
	    {
           
            var email = LbEmail.Text?.Trim();
            var password = LbPassword.Text?.Trim();

            if (string.IsNullOrEmpty(email))
            {
                await DisplayAlert("Thông báo", "Username không được để trống !", "OK");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Thông báo", "Password không được để trống !", "OK");
                return;
            }

	        try
	        {
	            var userService = new UserService();
	            //check môi trường
	            var indexEnv = pickerEnv.SelectedIndex;
	            App.APPCONFIG.Api = App.APPCONFIG.GetApiByEnv(indexEnv);
	            App.TOKEN = userService.GetToken(App.APPCONFIG.UserApi, App.APPCONFIG.PassApi);
	            var result = userService.Login(email, password);

	            if (result.Code == 0)
	            {
	                App.USER = result.Data.ToString().JsonToObject<User>();
	                //save local database
	                App.USER.Enviroment = indexEnv;
	                App.USER.Roles = string.Join(",", App.USER.RoleMenus);
                    await App.IEFSERVICE.SaveUserAsync(App.USER);

                    /*App.ROLE_ORDER_STEPS = JsonConvert.DeserializeObject<List<RoleOrderStep>>(result.Data.ToString());
                    if (App.ROLE_ORDER_STEPS.Any())
                    {
                        foreach (var roleOrderStep in App.ROLE_ORDER_STEPS)
                        {
                            await App.Database.SaveRoleOrderStepAsync(roleOrderStep);
                        }
                    }*/

                    /* Application.Current.MainPage = new NavigationPage(new ScanView())
                     {
                         BarBackgroundColor = (Color)Application.Current.Resources["BarColor"],
                     };*/
                    Application.Current.MainPage = new MainPage();
	            }
	            else
	            {
	                await DisplayAlert("Thông báo", result.Data.ToString(),"OK");
	                return;
	            }
	        }
	        catch (Exception ex)
	        {
	            await DisplayAlert("Thông báo", "Lỗi hệ thống:" + ex.Message, "OK");
	            return;
	        }
        }
	}
}