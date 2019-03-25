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
    /// Google BigQuery service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("GoogleBigQuery")]
    [Rest.Serialization.JsonTransformation]
    public partial class GoogleBigQueryLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the GoogleBigQueryLinkedService
        /// class.
        /// </summary>
        public GoogleBigQueryLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoogleBigQueryLinkedService
        /// class.
        /// </summary>
        /// <param name="project">The default BigQuery project to query
        /// against.</param>
        /// <param name="authenticationType">The OAuth 2.0 authentication
        /// mechanism used for authentication. ServiceAuthentication can only
        /// be used on self-hosted IR. Possible values include:
        /// 'ServiceAuthentication', 'UserAuthentication'</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="additionalProjects">A comma-separated list of public
        /// BigQuery projects to access.</param>
        /// <param name="requestGoogleDriveScope">Whether to request access to
        /// Google Drive. Allowing Google Drive access enables support for
        /// federated tables that combine BigQuery data with data from Google
        /// Drive. The default value is false.</param>
        /// <param name="refreshToken">The refresh token obtained from Google
        /// for authorizing access to BigQuery for UserAuthentication.</param>
        /// <param name="clientId">The client id of the google application used
        /// to acquire the refresh token.</param>
        /// <param name="clientSecret">The client secret of the google
        /// application used to acquire the refresh token.</param>
        /// <param name="email">The service account email ID that is used for
        /// ServiceAuthentication and can only be used on self-hosted
        /// IR.</param>
        /// <param name="keyFilePath">The full path to the .p12 key file that
        /// is used to authenticate the service account email address and can
        /// only be used on self-hosted IR.</param>
        /// <param name="trustedCertPath">The full path of the .pem file
        /// containing trusted CA certificates for verifying the server when
        /// connecting over SSL. This property can only be set when using SSL
        /// on self-hosted IR. The default value is the cacerts.pem file
        /// installed with the IR.</param>
        /// <param name="useSystemTrustStore">Specifies whether to use a CA
        /// certificate from the system trust store or from a specified PEM
        /// file. The default value is false.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public GoogleBigQueryLinkedService(object project, string authenticationType, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object additionalProjects = default(object), object requestGoogleDriveScope = default(object), SecretBase refreshToken = default(SecretBase), SecretBase clientId = default(SecretBase), SecretBase clientSecret = default(SecretBase), object email = default(object), object keyFilePath = default(object), object trustedCertPath = default(object), object useSystemTrustStore = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Project = project;
            AdditionalProjects = additionalProjects;
            RequestGoogleDriveScope = requestGoogleDriveScope;
            AuthenticationType = authenticationType;
            RefreshToken = refreshToken;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Email = email;
            KeyFilePath = keyFilePath;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the default BigQuery project to query against.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.project")]
        public object Project { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of public BigQuery projects to
        /// access.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.additionalProjects")]
        public object AdditionalProjects { get; set; }

        /// <summary>
        /// Gets or sets whether to request access to Google Drive. Allowing
        /// Google Drive access enables support for federated tables that
        /// combine BigQuery data with data from Google Drive. The default
        /// value is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.requestGoogleDriveScope")]
        public object RequestGoogleDriveScope { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 authentication mechanism used for
        /// authentication. ServiceAuthentication can only be used on
        /// self-hosted IR. Possible values include: 'ServiceAuthentication',
        /// 'UserAuthentication'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the refresh token obtained from Google for authorizing
        /// access to BigQuery for UserAuthentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.refreshToken")]
        public SecretBase RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the client id of the google application used to
        /// acquire the refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clientId")]
        public SecretBase ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret of the google application used to
        /// acquire the refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clientSecret")]
        public SecretBase ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the service account email ID that is used for
        /// ServiceAuthentication and can only be used on self-hosted IR.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.email")]
        public object Email { get; set; }

        /// <summary>
        /// Gets or sets the full path to the .p12 key file that is used to
        /// authenticate the service account email address and can only be used
        /// on self-hosted IR.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.keyFilePath")]
        public object KeyFilePath { get; set; }

        /// <summary>
        /// Gets or sets the full path of the .pem file containing trusted CA
        /// certificates for verifying the server when connecting over SSL.
        /// This property can only be set when using SSL on self-hosted IR. The
        /// default value is the cacerts.pem file installed with the IR.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trustedCertPath")]
        public object TrustedCertPath { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to use a CA certificate from the
        /// system trust store or from a specified PEM file. The default value
        /// is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useSystemTrustStore")]
        public object UseSystemTrustStore { get; set; }

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
            if (Project == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Project");
            }
            if (AuthenticationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthenticationType");
            }
        }
    }
}
