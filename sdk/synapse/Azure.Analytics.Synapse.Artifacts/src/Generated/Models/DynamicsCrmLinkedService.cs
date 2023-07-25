// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Dynamics CRM linked service. </summary>
    public partial class DynamicsCrmLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of DynamicsCrmLinkedService. </summary>
        /// <param name="deploymentType"> The deployment type of the Dynamics CRM instance. 'Online' for Dynamics CRM Online and 'OnPremisesWithIfd' for Dynamics CRM on-premises with Ifd. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The authentication type to connect to Dynamics CRM server. 'Office365' for online scenario, 'Ifd' for on-premises with Ifd scenario, 'AADServicePrincipal' for Server-To-Server authentication in online scenario. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentType"/> or <paramref name="authenticationType"/> is null. </exception>
        public DynamicsCrmLinkedService(object deploymentType, object authenticationType)
        {
            Argument.AssertNotNull(deploymentType, nameof(deploymentType));
            Argument.AssertNotNull(authenticationType, nameof(authenticationType));

            DeploymentType = deploymentType;
            AuthenticationType = authenticationType;
            Type = "DynamicsCrm";
        }

        /// <summary> Initializes a new instance of DynamicsCrmLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="deploymentType"> The deployment type of the Dynamics CRM instance. 'Online' for Dynamics CRM Online and 'OnPremisesWithIfd' for Dynamics CRM on-premises with Ifd. Type: string (or Expression with resultType string). </param>
        /// <param name="hostName"> The host name of the on-premises Dynamics CRM server. The property is required for on-prem and not allowed for online. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The port of on-premises Dynamics CRM server. The property is required for on-prem and not allowed for online. Default is 443. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="serviceUri"> The URL to the Microsoft Dynamics CRM server. The property is required for on-line and not allowed for on-prem. Type: string (or Expression with resultType string). </param>
        /// <param name="organizationName"> The organization name of the Dynamics CRM instance. The property is required for on-prem and required for online when there are more than one Dynamics CRM instances associated with the user. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The authentication type to connect to Dynamics CRM server. 'Office365' for online scenario, 'Ifd' for on-premises with Ifd scenario, 'AADServicePrincipal' for Server-To-Server authentication in online scenario. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> User name to access the Dynamics CRM instance. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password to access the Dynamics CRM instance.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="servicePrincipalId"> The client ID of the application in Azure Active Directory used for Server-To-Server authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalCredentialType"> A string from ServicePrincipalCredentialEnum or an expression. </param>
        /// <param name="servicePrincipalCredential">
        /// The credential of the service principal object in Azure Active Directory. If servicePrincipalCredentialType is 'ServicePrincipalKey', servicePrincipalCredential can be SecureString or AzureKeyVaultSecretReference. If servicePrincipalCredentialType is 'ServicePrincipalCert', servicePrincipalCredential can only be AzureKeyVaultSecretReference.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal DynamicsCrmLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object deploymentType, object hostName, object port, object serviceUri, object organizationName, object authenticationType, object username, SecretBase password, object servicePrincipalId, object servicePrincipalCredentialType, SecretBase servicePrincipalCredential, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            DeploymentType = deploymentType;
            HostName = hostName;
            Port = port;
            ServiceUri = serviceUri;
            OrganizationName = organizationName;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalCredentialType = servicePrincipalCredentialType;
            ServicePrincipalCredential = servicePrincipalCredential;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "DynamicsCrm";
        }

        /// <summary> The deployment type of the Dynamics CRM instance. 'Online' for Dynamics CRM Online and 'OnPremisesWithIfd' for Dynamics CRM on-premises with Ifd. Type: string (or Expression with resultType string). </summary>
        public object DeploymentType { get; set; }
        /// <summary> The host name of the on-premises Dynamics CRM server. The property is required for on-prem and not allowed for online. Type: string (or Expression with resultType string). </summary>
        public object HostName { get; set; }
        /// <summary> The port of on-premises Dynamics CRM server. The property is required for on-prem and not allowed for online. Default is 443. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object Port { get; set; }
        /// <summary> The URL to the Microsoft Dynamics CRM server. The property is required for on-line and not allowed for on-prem. Type: string (or Expression with resultType string). </summary>
        public object ServiceUri { get; set; }
        /// <summary> The organization name of the Dynamics CRM instance. The property is required for on-prem and required for online when there are more than one Dynamics CRM instances associated with the user. Type: string (or Expression with resultType string). </summary>
        public object OrganizationName { get; set; }
        /// <summary> The authentication type to connect to Dynamics CRM server. 'Office365' for online scenario, 'Ifd' for on-premises with Ifd scenario, 'AADServicePrincipal' for Server-To-Server authentication in online scenario. Type: string (or Expression with resultType string). </summary>
        public object AuthenticationType { get; set; }
        /// <summary> User name to access the Dynamics CRM instance. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary>
        /// Password to access the Dynamics CRM instance.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The client ID of the application in Azure Active Directory used for Server-To-Server authentication. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary> A string from ServicePrincipalCredentialEnum or an expression. </summary>
        public object ServicePrincipalCredentialType { get; set; }
        /// <summary>
        /// The credential of the service principal object in Azure Active Directory. If servicePrincipalCredentialType is 'ServicePrincipalKey', servicePrincipalCredential can be SecureString or AzureKeyVaultSecretReference. If servicePrincipalCredentialType is 'ServicePrincipalCert', servicePrincipalCredential can only be AzureKeyVaultSecretReference.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ServicePrincipalCredential { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
