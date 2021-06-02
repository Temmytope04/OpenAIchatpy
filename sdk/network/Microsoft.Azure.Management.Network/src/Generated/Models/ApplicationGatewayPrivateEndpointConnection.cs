// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Private Endpoint connection on an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayPrivateEndpointConnection : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayPrivateEndpointConnection class.
        /// </summary>
        public ApplicationGatewayPrivateEndpointConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayPrivateEndpointConnection class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="privateEndpoint">The resource of private end
        /// point.</param>
        /// <param name="privateLinkServiceConnectionState">A collection of
        /// information about the state of the connection between service
        /// consumer and provider.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// application gateway private endpoint connection resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'</param>
        /// <param name="linkIdentifier">The consumer link id.</param>
        /// <param name="name">Name of the private endpoint connection on an
        /// application gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayPrivateEndpointConnection(string id = default(string), PrivateEndpoint privateEndpoint = default(PrivateEndpoint), PrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionState), string provisioningState = default(string), string linkIdentifier = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            LinkIdentifier = linkIdentifier;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource of private end point.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpoint")]
        public PrivateEndpoint PrivateEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets a collection of information about the state of the
        /// connection between service consumer and provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// Gets the provisioning state of the application gateway private
        /// endpoint connection resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the consumer link id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkIdentifier")]
        public string LinkIdentifier { get; private set; }

        /// <summary>
        /// Gets or sets name of the private endpoint connection on an
        /// application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
