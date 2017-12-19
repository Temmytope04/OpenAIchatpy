// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The key value pair object properties.
    /// </summary>
    public partial class KeyValuePair
    {
        /// <summary>
        /// Initializes a new instance of the KeyValuePair class.
        /// </summary>
        public KeyValuePair()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyValuePair class.
        /// </summary>
        /// <param name="key">The key parameter.</param>
        /// <param name="value">The value parameter.</param>
        public KeyValuePair(string key = default(string), string value = default(string))
        {
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the key parameter.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value parameter.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
