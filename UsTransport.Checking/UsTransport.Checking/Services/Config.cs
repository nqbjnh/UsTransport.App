using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ScanCode.Models;
using UsTransport.Checking.Utils;

namespace UsTransport.Checking.Services
{
    public class Config
    {

        public AppConfig GetAppConfig()
        {
            try
            {
                var result = Client.Get<JObject>("https://gist.githubusercontent.com/nqbjnh/a584716cc54e2449f34163a8140d4c7b/raw/a8481f5bf9145df576f5196ae9fac2ab383ea374/UsTransport.App.Checking.config");
                return new AppConfig(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}