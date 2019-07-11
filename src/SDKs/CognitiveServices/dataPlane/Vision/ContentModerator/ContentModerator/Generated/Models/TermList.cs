// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Term List  Properties.
    /// </summary>
    public partial class TermList
    {
        /// <summary>
        /// Initializes a new instance of the TermList class.
        /// </summary>
        public TermList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TermList class.
        /// </summary>
        /// <param name="id">Term list Id.</param>
        /// <param name="name">Term list name.</param>
        /// <param name="description">Description for term list.</param>
        /// <param name="metadata">Term list metadata.</param>
        public TermList(int? id = default(int?), string name = default(string), string description = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>))
        {
            Id = id;
            Name = name;
            Description = description;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets term list Id.
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets term list name.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description for term list.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets term list metadata.
        /// </summary>
        [JsonProperty(PropertyName = "Metadata")]
        public IDictionary<string, string> Metadata { get; set; }

    }
}
