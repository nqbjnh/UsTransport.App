using System;
using System.Linq;
using ScanCode.Models;
using UsTransport.Checking.Services;
using Xamarin.Forms;
using UsTransport.Checking.Views;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.EntityFrameworkCore;
using UsTransport.Checking.Models;
using UsTransport.Checking.Utils;
using Device = Xamarin.Forms.Device;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace UsTransport.Checking
{
	public partial class App : Application
	{
	    public static AppConfig APPCONFIG;
	    public static string TOKEN;
	    public static string APP_VERSION;
	    public static User USER;
	    public static IEFService IEFSERVICE;
        public App ()
		{
			InitializeComponent();
			//MainPage = new Login();
		}



		protected override async void OnStart ()
		{
		    AppCenter.Start("android=8cdf0827-a552-4ecb-88f7-c35c58a58dc9;",typeof(Analytics), typeof(Crashes));

            // Handle when your app starts
            IEFSERVICE = new EfService();
            var ihelper = DependencyService.Get<IHelper>();
            var config = new Config();
		    APPCONFIG = config.GetAppConfig();
		    APP_VERSION = ihelper.AppVersion;
		    bool hasUpdate = false;
            string urlUpdateApp;
            var userService = new UserService();
            USER = IEFSERVICE.GetUser();
            if (USER != null)
            {
                USER.RoleMenus = USER.Roles.Split(',').Select(int.Parse).ToList();
                var api = APPCONFIG.GetApiByEnv(USER.Enviroment);
		        TOKEN = userService.GetToken(APPCONFIG.UserApi, APPCONFIG.PassApi);

                MainPage = new MainPage();
            }
		    else
		    {
		        MainPage = new Login();
		    }

            if (Device.RuntimePlatform == Device.iOS)
		    {
		        urlUpdateApp = APPCONFIG.StoreIos;
		        hasUpdate = !APP_VERSION.Equals(APPCONFIG.IosVersion);
		    }
		    else
		    {
		        urlUpdateApp = APPCONFIG.StoreAndroid;
		        hasUpdate = !APP_VERSION.Equals(APPCONFIG.AndroidVersion);
		    }

		    if (hasUpdate)
		    {
		        var result = await Current.MainPage.DisplayAlert("Cập nhật phiên bản mới", "Đã có phiên bản cập nhật. Bạn có muốn cập nhật không ?", "Ok", "Cancel"); // since we are using async, we should specify the DisplayAlert as awaiting.
		        if (result) // if it's equal to Ok
		        {
		            Device.OpenUri(new Uri(urlUpdateApp));
		        }
		    }
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
