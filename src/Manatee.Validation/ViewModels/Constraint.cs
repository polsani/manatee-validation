using System.Collections.Generic;
using Newtonsoft.Json;

namespace Manatee.Validation.ViewModels
{
    public class Constraint
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }
        
        [JsonProperty(PropertyName = "params")]
        public IEnumerable<Param> Params { get; private set; }

        public Constraint(string name, IEnumerable<Param> @params)
        {
            Name = name;
            Params = @params;
        }
    }
}