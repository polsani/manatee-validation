using System.Collections.Generic;
using Newtonsoft.Json;

namespace Manatee.Validation.Notifications
{
    public class Constraint
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }
        
        [JsonProperty(PropertyName = "params")]
        public IEnumerable<Param> Parameters { get; private set; }

        public Constraint(string name, IEnumerable<Param> parameters)
        {
            Name = name;
            Parameters = parameters;
        }
    }
}