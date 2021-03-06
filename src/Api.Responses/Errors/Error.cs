using System.Collections.Generic;

namespace Api.Responses.Errors
{
    /// <summary>
    /// Following the api-guidlines found here https://github.com/Microsoft/api-guidelines/blob/master/Guidelines.md#7102-error-condition-responses
    /// </summary>
    public class Error
    {
        public Error(string code, string message, string target = null)
        {
            Code = code;
            Message = message;
            Target = target;
        }

        /// <summary>
        /// One of a server-defined set of error codes.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// A human-readable representation of the error.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The target of the error.
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// An array of details about specific errors that led to this reported error.
        /// </summary>
        public List<Error> Details { get; set; } = new List<Error>();
    }

}
