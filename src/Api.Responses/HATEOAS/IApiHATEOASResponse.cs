using System.Collections.Generic;
using Newtonsoft.Json;

namespace Api.Responses.HATEOAS
{
    public interface IApiHATEOASResponse : IApiResponse
    {
        [JsonProperty("_links")]
        List<Link> Links { get; }
    }
}
