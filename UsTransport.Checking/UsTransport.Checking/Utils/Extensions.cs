using Newtonsoft.Json;

namespace UsTransport.Checking.Utils
{
    public static class Extensions
    {
        public static string ToJson(this object Obj)
        {
            return JsonConvert.SerializeObject(Obj);
        }

        public static T JsonToObject<T>(this string Data)
        {
            return JsonConvert.DeserializeObject<T>(Data);
        }
    }
}