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

	    private void BtnLogin_OnClicked(object sender, EventArgs e)
	    {
            LbError.IsVisible = false;
            var email = LbEmail.Text?.Trim();
            var password = LbPassword.Text?.Trim();

            if (string.IsNullOrEmpty(email))
            {
                LbError.IsVisible = true;
                LbError.Text = "Username không được để trống !";
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                LbError.IsVisible = true;
                LbError.Text = "Password không được để trống !";
                return;
            }

            try
            {
                var userService = new UserService();
                //check môi trường
                var indexEnv = pickerEnv.SelectedIndex;
                var api = App.APPCONFIG.GetApiByEnv(indexEnv);
                App.TOKEN = userService.GetToken(App.APPCONFIG.UserApi, App.APPCONFIG.PassApi);
                var result = userService.Login(email, password);
                
                if (result.Code == 0)
                {
                    App.USER = result.Data.ToString().JsonToObject<User>();
                    //save local database
                    /* App.User = new User()
                     {
                         Email = LbEmail.Text,
                         Password = LbPassword.Text,
                         Enviroment = indexEnv
                     };
                     await App.Database.SaveUserAsync(App.User);

                     App.ROLE_ORDER_STEPS = JsonConvert.DeserializeObject<List<RoleOrderStep>>(result.Data.ToString());
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
                    Application.Current.MainPage = new NavigationPage(new MainPage());
                }
                else
                {
                    LbError.IsVisible = true;
                    LbError.Text = result.Data.ToString();
                    return;
                }
            }
            catch (Exception ex)
            {
                LbError.IsVisible = true;
                LbError.Text = "Lỗi hệ thống:"+ ex.Message;
                return;
            }
        }
	}
}