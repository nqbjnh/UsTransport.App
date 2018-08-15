using System.IO;
using UsTransport.Checking.Droid.Services;
using UsTransport.Checking.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(HelperService))]
namespace UsTransport.Checking.Droid.Services
{
    public class HelperService :IHelper
    {
        public string AppVersion
        {
            get
            {
                var context = Forms.Context;
                return context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;
            }
        }
        public string GetDbPath(string dbName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
        }
    }
}