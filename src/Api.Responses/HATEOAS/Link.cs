using System.Collections.Generic;
using Newtonsoft.Json;

namespace Api.Responses.HATEOAS
{
    /// <summary>
    ///  HATEOAS, or Hypertext as the Engine of Application State Link.
    ///  See more info at https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design#use-hateoas-to-enable-navigation-to-related-resources
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Hyperlink to the resource
        /// </summary>
        public string Href { get; }

        /// <summary>
        /// Relation to the resource
        /// </summary>
        [JsonProperty("rel")]
        public string Relation { get; }

        /// <summary>
        /// Http Method to use when navigating to the <see cref="Href"/>
        /// </summary>
        public string Method { get; }

        /// <summary>
        /// List of content types that are supported
        /// </summary>
        public List<string> Types { get; }
    }
}
