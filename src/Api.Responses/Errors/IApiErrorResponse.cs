using Newtonsoft.Json;

namespace Api.Responses.Errors
{
    public interface IApiErrorResponse : IApiResponse
    {
        [JsonProperty("error")]
        Error Error { get; }
    }
}
