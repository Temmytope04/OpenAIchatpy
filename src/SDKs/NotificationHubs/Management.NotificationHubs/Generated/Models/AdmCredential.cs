// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.NotificationHubs;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of a NotificationHub AdmCredential.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AdmCredential
    {
        /// <summary>
        /// Initializes a new instance of the AdmCredential class.
        /// </summary>
        public AdmCredential()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdmCredential class.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The credential secret access
        /// key.</param>
        /// <param name="authTokenUrl">The URL of the authorization
        /// token.</param>
        public AdmCredential(string clientId = default(string), string clientSecret = default(string), string authTokenUrl = default(string))
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AuthTokenUrl = authTokenUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the credential secret access key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the URL of the authorization token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authTokenUrl")]
        public string AuthTokenUrl { get; set; }

    }
}
