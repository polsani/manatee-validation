using Newtonsoft.Json;

namespace Manatee.Validation.Notifications
{
    public sealed class Notification
    {
        [JsonIgnore]
        public int HttpStatusCode { get; private set; }
        
        [JsonProperty(PropertyName = "property")]
        public string Property { get; private set; }
        
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }
        
        [JsonProperty(PropertyName = "value")]
        public object Value { get; private set; }

        [JsonProperty(PropertyName = "constraint")]
        public Constraint Constraint { get; private set; }
        
        public Notification(int httpStatusCode, 
            string property, 
            string message, 
            object value, 
            Constraint constraint)
        {
            HttpStatusCode = httpStatusCode;
            Property = property;
            Message = message;
            Value = value;
            Constraint = constraint;
        }
    }
}