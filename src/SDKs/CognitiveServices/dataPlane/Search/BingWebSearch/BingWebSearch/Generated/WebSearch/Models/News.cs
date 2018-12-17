// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.WebSearch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a news answer.
    /// </summary>
    public partial class News : SearchResultsAnswer
    {
        /// <summary>
        /// Initializes a new instance of the News class.
        /// </summary>
        public News()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the News class.
        /// </summary>
        /// <param name="value">An array of NewsArticle objects that contain
        /// information about news articles that are relevant to the query. If
        /// there are no results to return for the request, the array is
        /// empty.</param>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="totalEstimatedMatches">The estimated number of
        /// webpages that are relevant to the query. Use this number along with
        /// the count and offset query parameters to page the results.</param>
        public News(IList<NewsArticle> value, string id = default(string), string webSearchUrl = default(string), IList<Query> followUpQueries = default(IList<Query>), QueryContext queryContext = default(QueryContext), long? totalEstimatedMatches = default(long?), bool? isFamilyFriendly = default(bool?), string location = default(string))
            : base(id, webSearchUrl, followUpQueries, queryContext, totalEstimatedMatches, isFamilyFriendly)
        {
            Value = value;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of NewsArticle objects that contain
        /// information about news articles that are relevant to the query. If
        /// there are no results to return for the request, the array is empty.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<NewsArticle> Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
