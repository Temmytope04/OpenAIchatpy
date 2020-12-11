// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class DataMaskingPolicy : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DataMaskingPolicy class.
        /// </summary>
        public DataMaskingPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataMaskingPolicy class.
        /// </summary>
        /// <param name="dataMaskingState">The state of the data masking
        /// policy. Possible values include: 'Disabled', 'Enabled'</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="exemptPrincipals">The list of the exempt principals.
        /// Specifies the semicolon-separated list of database users for which
        /// the data masking policy does not apply. The specified users receive
        /// data results without masking for all of the database
        /// queries.</param>
        /// <param name="applicationPrincipals">The list of the application
        /// principals. This is a legacy parameter and is no longer
        /// used.</param>
        /// <param name="maskingLevel">The masking level. This is a legacy
        /// parameter and is no longer used.</param>
        /// <param name="location">The location of the data masking
        /// policy.</param>
        /// <param name="kind">The kind of data masking policy. Metadata, used
        /// for Azure portal.</param>
        public DataMaskingPolicy(DataMaskingState dataMaskingState, string id = default(string), string name = default(string), string type = default(string), string exemptPrincipals = default(string), string applicationPrincipals = default(string), string maskingLevel = default(string), string location = default(string), string kind = default(string))
            : base(id, name, type)
        {
            DataMaskingState = dataMaskingState;
            ExemptPrincipals = exemptPrincipals;
            ApplicationPrincipals = applicationPrincipals;
            MaskingLevel = maskingLevel;
            Location = location;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the data masking policy. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataMaskingState")]
        public DataMaskingState DataMaskingState { get; set; }

        /// <summary>
        /// Gets or sets the list of the exempt principals. Specifies the
        /// semicolon-separated list of database users for which the data
        /// masking policy does not apply. The specified users receive data
        /// results without masking for all of the database queries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.exemptPrincipals")]
        public string ExemptPrincipals { get; set; }

        /// <summary>
        /// Gets the list of the application principals. This is a legacy
        /// parameter and is no longer used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicationPrincipals")]
        public string ApplicationPrincipals { get; private set; }

        /// <summary>
        /// Gets the masking level. This is a legacy parameter and is no longer
        /// used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maskingLevel")]
        public string MaskingLevel { get; private set; }

        /// <summary>
        /// Gets the location of the data masking policy.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets the kind of data masking policy. Metadata, used for Azure
        /// portal.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
