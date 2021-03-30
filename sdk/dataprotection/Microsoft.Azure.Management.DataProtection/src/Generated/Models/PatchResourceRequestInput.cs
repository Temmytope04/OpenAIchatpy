// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PatchResourceRequestInput
    /// </summary>
    /// <remarks>
    /// Patch Request content for Microsoft.DataProtection resources
    /// </remarks>
    public partial class PatchResourceRequestInput
    {
        /// <summary>
        /// Initializes a new instance of the PatchResourceRequestInput class.
        /// </summary>
        public PatchResourceRequestInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchResourceRequestInput class.
        /// </summary>
        /// <param name="identity">Input Managed Identity Details</param>
        /// <param name="tags">Resource tags.</param>
        public PatchResourceRequestInput(DppIdentityDetails identity = default(DppIdentityDetails), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Identity = identity;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets input Managed Identity Details
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public DppIdentityDetails Identity { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
