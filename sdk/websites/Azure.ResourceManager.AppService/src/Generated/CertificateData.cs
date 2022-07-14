// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the Certificate data model. </summary>
    public partial class CertificateData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of CertificateData. </summary>
        /// <param name="location"> The location. </param>
        public CertificateData(AzureLocation location) : base(location)
        {
            HostNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="password">
        /// Certificate password.
        /// Serialized Name: Certificate.properties.password
        /// </param>
        /// <param name="friendlyName">
        /// Friendly name of the certificate.
        /// Serialized Name: Certificate.properties.friendlyName
        /// </param>
        /// <param name="subjectName">
        /// Subject name of the certificate.
        /// Serialized Name: Certificate.properties.subjectName
        /// </param>
        /// <param name="hostNames">
        /// Host names the certificate applies to.
        /// Serialized Name: Certificate.properties.hostNames
        /// </param>
        /// <param name="pfxBlob">
        /// Pfx blob.
        /// Serialized Name: Certificate.properties.pfxBlob
        /// </param>
        /// <param name="siteName">
        /// App name.
        /// Serialized Name: Certificate.properties.siteName
        /// </param>
        /// <param name="selfLink">
        /// Self link.
        /// Serialized Name: Certificate.properties.selfLink
        /// </param>
        /// <param name="issuer">
        /// Certificate issuer.
        /// Serialized Name: Certificate.properties.issuer
        /// </param>
        /// <param name="issueOn">
        /// Certificate issue Date.
        /// Serialized Name: Certificate.properties.issueDate
        /// </param>
        /// <param name="expireOn">
        /// Certificate expiration date.
        /// Serialized Name: Certificate.properties.expirationDate
        /// </param>
        /// <param name="thumbprint">
        /// Certificate thumbprint.
        /// Serialized Name: Certificate.properties.thumbprint
        /// </param>
        /// <param name="isValid">
        /// Is the certificate valid?.
        /// Serialized Name: Certificate.properties.valid
        /// </param>
        /// <param name="cerBlob">
        /// Raw bytes of .cer file
        /// Serialized Name: Certificate.properties.cerBlob
        /// </param>
        /// <param name="publicKeyHash">
        /// Public key hash.
        /// Serialized Name: Certificate.properties.publicKeyHash
        /// </param>
        /// <param name="hostingEnvironmentProfile">
        /// Specification for the App Service Environment to use for the certificate.
        /// Serialized Name: Certificate.properties.hostingEnvironmentProfile
        /// </param>
        /// <param name="keyVaultId">
        /// Key Vault Csm resource Id.
        /// Serialized Name: Certificate.properties.keyVaultId
        /// </param>
        /// <param name="keyVaultSecretName">
        /// Key Vault secret name.
        /// Serialized Name: Certificate.properties.keyVaultSecretName
        /// </param>
        /// <param name="keyVaultSecretStatus">
        /// Status of the Key Vault secret.
        /// Serialized Name: Certificate.properties.keyVaultSecretStatus
        /// </param>
        /// <param name="appServicePlanId">
        /// Resource ID of the associated App Service plan, formatted as: &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
        /// Serialized Name: Certificate.properties.serverFarmId
        /// </param>
        /// <param name="canonicalName">
        /// CNAME of the certificate to be issued via free certificate
        /// Serialized Name: Certificate.properties.canonicalName
        /// </param>
        /// <param name="domainValidationMethod">
        /// Method of domain validation for free cert
        /// Serialized Name: Certificate.properties.domainValidationMethod
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: Resource.kind
        /// </param>
        internal CertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string password, string friendlyName, string subjectName, IList<string> hostNames, byte[] pfxBlob, string siteName, string selfLink, string issuer, DateTimeOffset? issueOn, DateTimeOffset? expireOn, string thumbprint, bool? isValid, byte[] cerBlob, string publicKeyHash, HostingEnvironmentProfile hostingEnvironmentProfile, ResourceIdentifier keyVaultId, string keyVaultSecretName, KeyVaultSecretStatus? keyVaultSecretStatus, ResourceIdentifier appServicePlanId, string canonicalName, string domainValidationMethod, string kind) : base(id, name, resourceType, systemData, tags, location)
        {
            Password = password;
            FriendlyName = friendlyName;
            SubjectName = subjectName;
            HostNames = hostNames;
            PfxBlob = pfxBlob;
            SiteName = siteName;
            SelfLink = selfLink;
            Issuer = issuer;
            IssueOn = issueOn;
            ExpireOn = expireOn;
            Thumbprint = thumbprint;
            IsValid = isValid;
            CerBlob = cerBlob;
            PublicKeyHash = publicKeyHash;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            KeyVaultSecretStatus = keyVaultSecretStatus;
            AppServicePlanId = appServicePlanId;
            CanonicalName = canonicalName;
            DomainValidationMethod = domainValidationMethod;
            Kind = kind;
        }

        /// <summary>
        /// Certificate password.
        /// Serialized Name: Certificate.properties.password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Friendly name of the certificate.
        /// Serialized Name: Certificate.properties.friendlyName
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// Subject name of the certificate.
        /// Serialized Name: Certificate.properties.subjectName
        /// </summary>
        public string SubjectName { get; }
        /// <summary>
        /// Host names the certificate applies to.
        /// Serialized Name: Certificate.properties.hostNames
        /// </summary>
        public IList<string> HostNames { get; }
        /// <summary>
        /// Pfx blob.
        /// Serialized Name: Certificate.properties.pfxBlob
        /// </summary>
        public byte[] PfxBlob { get; set; }
        /// <summary>
        /// App name.
        /// Serialized Name: Certificate.properties.siteName
        /// </summary>
        public string SiteName { get; }
        /// <summary>
        /// Self link.
        /// Serialized Name: Certificate.properties.selfLink
        /// </summary>
        public string SelfLink { get; }
        /// <summary>
        /// Certificate issuer.
        /// Serialized Name: Certificate.properties.issuer
        /// </summary>
        public string Issuer { get; }
        /// <summary>
        /// Certificate issue Date.
        /// Serialized Name: Certificate.properties.issueDate
        /// </summary>
        public DateTimeOffset? IssueOn { get; }
        /// <summary>
        /// Certificate expiration date.
        /// Serialized Name: Certificate.properties.expirationDate
        /// </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary>
        /// Certificate thumbprint.
        /// Serialized Name: Certificate.properties.thumbprint
        /// </summary>
        public string Thumbprint { get; }
        /// <summary>
        /// Is the certificate valid?.
        /// Serialized Name: Certificate.properties.valid
        /// </summary>
        public bool? IsValid { get; }
        /// <summary>
        /// Raw bytes of .cer file
        /// Serialized Name: Certificate.properties.cerBlob
        /// </summary>
        public byte[] CerBlob { get; }
        /// <summary>
        /// Public key hash.
        /// Serialized Name: Certificate.properties.publicKeyHash
        /// </summary>
        public string PublicKeyHash { get; }
        /// <summary>
        /// Specification for the App Service Environment to use for the certificate.
        /// Serialized Name: Certificate.properties.hostingEnvironmentProfile
        /// </summary>
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; }
        /// <summary>
        /// Key Vault Csm resource Id.
        /// Serialized Name: Certificate.properties.keyVaultId
        /// </summary>
        public ResourceIdentifier KeyVaultId { get; set; }
        /// <summary>
        /// Key Vault secret name.
        /// Serialized Name: Certificate.properties.keyVaultSecretName
        /// </summary>
        public string KeyVaultSecretName { get; set; }
        /// <summary>
        /// Status of the Key Vault secret.
        /// Serialized Name: Certificate.properties.keyVaultSecretStatus
        /// </summary>
        public KeyVaultSecretStatus? KeyVaultSecretStatus { get; }
        /// <summary>
        /// Resource ID of the associated App Service plan, formatted as: &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
        /// Serialized Name: Certificate.properties.serverFarmId
        /// </summary>
        public ResourceIdentifier AppServicePlanId { get; set; }
        /// <summary>
        /// CNAME of the certificate to be issued via free certificate
        /// Serialized Name: Certificate.properties.canonicalName
        /// </summary>
        public string CanonicalName { get; set; }
        /// <summary>
        /// Method of domain validation for free cert
        /// Serialized Name: Certificate.properties.domainValidationMethod
        /// </summary>
        public string DomainValidationMethod { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: Resource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
