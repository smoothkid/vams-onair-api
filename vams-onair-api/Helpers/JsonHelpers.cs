using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using vams_onair_api.Models;

namespace vams_onair_api.Helpers
{
    class CompanyConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Company));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject wrapper = JObject.Load(reader);
            return wrapper["Content"].ToObject<Company>();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("content");
            writer.WriteRawValue(JsonConvert.SerializeObject(value));
            writer.WriteEndObject();
        }
    }
}
