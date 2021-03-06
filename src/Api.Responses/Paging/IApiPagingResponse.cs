using Newtonsoft.Json;

namespace Api.Responses.Paging
{
    public interface IApiPagingResponse : IApiResponse
    {
        [JsonProperty("size")]
        int Size { get; }

        [JsonProperty("page")]
        int Page { get; }

        [JsonProperty("limit")]
        int Limit { get; }

        [JsonProperty("hasMore")]
        bool HasMore { get; }
    }

}
