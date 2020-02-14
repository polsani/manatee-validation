using System.Data;
using Newtonsoft.Json;

namespace Manatee.Validation.ViewModels
{
    public class Error
    {
        [JsonProperty(PropertyName = "property")]
        public string Property { get; private set; }
        
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }
        
        [JsonProperty(PropertyName = "value")]
        public object Value { get; private set; }

        [JsonProperty(PropertyName = "constraint")]
        public Constraint Constraint { get; private set; }

        public Error(string property, string message, object value, Constraint constraint)
        {
            Property = property;
            Message = message;
            Value = value;
            Constraint = constraint;
        }
    }
}