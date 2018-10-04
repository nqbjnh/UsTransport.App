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
                var result = Client.Get<JObject>("http://apiweship.usexpress.vn/appconfig.json");
                return new AppConfig(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}