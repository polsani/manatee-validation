using System.Collections.Generic;
using Newtonsoft.Json;

namespace Manatee.Validation.ViewModels
{
    public class ErrorResponse
    {
        [JsonProperty(PropertyName = "errors")]
        public IList<Error> Errors { get; }
        
        [JsonIgnore]
        public int HttpStatusCode { get; }

        public ErrorResponse(int httpStatusCode)
        {
            HttpStatusCode = httpStatusCode;
            Errors = new List<Error>();
        }
    }
}