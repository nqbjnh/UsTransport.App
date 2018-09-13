using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ScanCode.Models
{
    public class AppConfig
    {

        public string IosVersion { get; set; }
        public string AndroidVersion { get; set; }
        public string StoreIos { get; set; }
        public string StoreAndroid { get; set; }
        public string Api { get; set; }
        public string Token { get; set; }
        public string ApiTest { get; set; }
        public string TokenTest { get; set; }
        public string ApiDev { get; set; }
        public string TokenDev { get; set; }
        public string UserApi { get; set; }
        public string PassApi { get; set; }
        public string CurrentEnv { get; set; }

        public Dictionary<int,string> DicEnviroment { get; set; }

        public AppConfig()
        {
            
        }

        public AppConfig(JObject appConfig)
        {
            DicEnviroment =
                new Dictionary<int, string> {{0, "Môi trường thật"}, {1, "Môi trường test"}, {2, "Môi trường dev"}};

            IosVersion = appConfig.Value<string>("ios");
            AndroidVersion = appConfig.Value<string>("android");
            StoreIos = appConfig.Value<string>("storeIos");
            StoreAndroid = appConfig.Value<string>("storeAndroid");
            Api = appConfig.Value<string>("api");
            Token = appConfig.Value<string>("token");
            ApiTest = appConfig.Value<string>("apiTest");
            TokenTest = appConfig.Value<string>("tokenTest");
            ApiDev = appConfig.Value<string>("apiDev");
            TokenDev = appConfig.Value<string>("tokenDev");
            UserApi = Token.Split('/').First();
            PassApi = Token.Split('/').Last();

        }

        public string GetApiByEnv(int indexEnv)
        {
            CurrentEnv = DicEnviroment[indexEnv];
            if (indexEnv == 0) // thật
            {
                UserApi = Token.Split('/').First();
                PassApi = Token.Split('/').Last();
                return Api;
            }
            if (indexEnv == 1) // test
            {
                UserApi = TokenTest.Split('/').First();
                PassApi = TokenTest.Split('/').Last();
                return ApiTest;
            }
            if (indexEnv == 2) // dev
            {
                UserApi = TokenDev.Split('/').First();
                PassApi = TokenDev.Split('/').Last();
                return ApiDev;
            }
            
            return Api;
        }
    }
}