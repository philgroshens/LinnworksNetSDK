using Newtonsoft.Json;

namespace LinnworksAPI
{
    public static class MainMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };
    }
}