using System;
using ScanCode.Models;
using UsTransport.Checking.Services;
using Xamarin.Forms;
using UsTransport.Checking.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace UsTransport.Checking
{
	public partial class App : Application
	{
	    public static AppConfig APPCONFIG;
        public App ()
		{
			InitializeComponent();


			MainPage = new MainPage();
		}

		protected override async void OnStart ()
		{
            // Handle when your app starts
		    var ihelper = DependencyService.Get<IHelper>();
            var config = new Config();
		    APPCONFIG = config.GetAppConfig();
		    var appVersion = ihelper.AppVersion;
		    bool hasUpdate = false;
            string urlUpdateApp;
            if (Device.RuntimePlatform == Device.iOS)
		    {
		        urlUpdateApp = APPCONFIG.StoreIos;
		        hasUpdate = !appVersion.Equals(APPCONFIG.IosVersion);
		    }
		    else
		    {
		        urlUpdateApp = APPCONFIG.StoreAndroid;
		        hasUpdate = !appVersion.Equals(APPCONFIG.AndroidVersion);
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
