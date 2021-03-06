namespace Api.Responses.Errors
{
    public class ApiErrorResponse : IApiErrorResponse
    {
        public Error Error { get; }

        public ApiErrorResponse(Error error)
        {
            Error = error;
        }
    }
}
