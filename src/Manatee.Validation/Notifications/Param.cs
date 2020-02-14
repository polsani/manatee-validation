using Newtonsoft.Json;

namespace Manatee.Validation.Notifications
{
    public class Param
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }
        
        [JsonProperty(PropertyName = "value")]
        public object Value { get; private set; }

        public Param(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}