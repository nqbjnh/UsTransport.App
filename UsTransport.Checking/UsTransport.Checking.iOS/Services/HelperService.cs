using System;
using System.IO;
using Foundation;
using UsTransport.Checking.iOS.Services;
using UsTransport.Checking.Services;

[assembly: Xamarin.Forms.Dependency(typeof(HelperService))]
namespace UsTransport.Checking.iOS.Services
{
    public class HelperService :IHelper
    {
        public string AppVersion
        {
            get
            {
                NSObject ver = NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"];
                return ver.ToString();
            }
        }

        public string GetDbPath(string dbName)
        {
            var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, dbName);
        }
    }
}