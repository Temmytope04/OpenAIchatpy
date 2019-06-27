// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// QuickBooks server linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("QuickBooks")]
    [Rest.Serialization.JsonTransformation]
    public partial class QuickBooksLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the QuickBooksLinkedService class.
        /// </summary>
        public QuickBooksLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuickBooksLinkedService class.
        /// </summary>
        /// <param name="endpoint">The endpoint of the QuickBooks server. (i.e.
        /// quickbooks.api.intuit.com)</param>
        /// <param name="companyId">The company ID of the QuickBooks company to
        /// authorize.</param>
        /// <param name="consumerKey">The consumer key for OAuth 1.0
        /// authentication.</param>
        /// <param name="consumerSecret">The consumer secret for OAuth 1.0
        /// authentication.</param>
        /// <param name="accessToken">The access token for OAuth 1.0
        /// authentication.</param>
        /// <param name="accessTokenSecret">The access token secret for OAuth
        /// 1.0 authentication.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="useEncryptedEndpoints">Specifies whether the data
        /// source endpoints are encrypted using HTTPS. The default value is
        /// true.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public QuickBooksLinkedService(object endpoint, object companyId, object consumerKey, SecretBase consumerSecret, SecretBase accessToken, SecretBase accessTokenSecret, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object useEncryptedEndpoints = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Endpoint = endpoint;
            CompanyId = companyId;
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            AccessToken = accessToken;
            AccessTokenSecret = accessTokenSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint of the QuickBooks server. (i.e.
        /// quickbooks.api.intuit.com)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.endpoint")]
        public object Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the company ID of the QuickBooks company to authorize.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.companyId")]
        public object CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the consumer key for OAuth 1.0 authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.consumerKey")]
        public object ConsumerKey { get; set; }

        /// <summary>
        /// Gets or sets the consumer secret for OAuth 1.0 authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.consumerSecret")]
        public SecretBase ConsumerSecret { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth 1.0 authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessToken")]
        public SecretBase AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the access token secret for OAuth 1.0 authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessTokenSecret")]
        public SecretBase AccessTokenSecret { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are
        /// encrypted using HTTPS. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useEncryptedEndpoints")]
        public object UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
            if (CompanyId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CompanyId");
            }
            if (ConsumerKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsumerKey");
            }
            if (ConsumerSecret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsumerSecret");
            }
            if (AccessToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessToken");
            }
            if (AccessTokenSecret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessTokenSecret");
            }
        }
    }
}
