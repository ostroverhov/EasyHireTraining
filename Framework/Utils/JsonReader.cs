using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Framework.Utils
{
    public static class JsonReader
    {
        public static T SetConfigModel<T>(string path = null) where T : class
        { 
            JObject jModel;
            var assembly = Assembly.GetCallingAssembly();
            var resourcePath = path ?? $"{assembly.GetName().Name}.Resources.{typeof(T).Name}.json";
            using (var stream = assembly.GetManifestResourceStream(resourcePath))
            using (JsonTextReader reader = new JsonTextReader(new StreamReader(stream)))
            {
                jModel = (JObject)JToken.ReadFrom(reader);
            }

            return jModel.ToObject<T>();
        }
    }
}