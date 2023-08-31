// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> API base contract details. </summary>
    public partial class ApiEntityBaseContract
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiEntityBaseContract"/>. </summary>
        internal ApiEntityBaseContract()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiEntityBaseContract"/>. </summary>
        /// <param name="description"> Description of the API. May include HTML formatting tags. </param>
        /// <param name="authenticationSettings"> Collection of authentication settings included into this API. </param>
        /// <param name="subscriptionKeyParameterNames"> Protocols over which API is made available. </param>
        /// <param name="apiType"> Type of API. </param>
        /// <param name="apiRevision"> Describes the revision of the API. If no value is provided, default revision 1 is created. </param>
        /// <param name="apiVersion"> Indicates the version identifier of the API if the API is versioned. </param>
        /// <param name="isCurrent"> Indicates if API revision is current api revision. </param>
        /// <param name="isOnline"> Indicates if API revision is accessible via the gateway. </param>
        /// <param name="apiRevisionDescription"> Description of the API Revision. </param>
        /// <param name="apiVersionDescription"> Description of the API Version. </param>
        /// <param name="apiVersionSetId"> A resource identifier for the related ApiVersionSet. </param>
        /// <param name="isSubscriptionRequired"> Specifies whether an API or Product subscription is required for accessing the API. </param>
        /// <param name="termsOfServiceUri"> A URL to the Terms of Service for the API. MUST be in the format of a URL. </param>
        /// <param name="contact"> Contact information for the API. </param>
        /// <param name="license"> License information for the API. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiEntityBaseContract(string description, AuthenticationSettingsContract authenticationSettings, SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames, ApiType? apiType, string apiRevision, string apiVersion, bool? isCurrent, bool? isOnline, string apiRevisionDescription, string apiVersionDescription, ResourceIdentifier apiVersionSetId, bool? isSubscriptionRequired, Uri termsOfServiceUri, ApiContactInformation contact, ApiLicenseInformation license, Dictionary<string, BinaryData> rawData)
        {
            Description = description;
            AuthenticationSettings = authenticationSettings;
            SubscriptionKeyParameterNames = subscriptionKeyParameterNames;
            ApiType = apiType;
            ApiRevision = apiRevision;
            ApiVersion = apiVersion;
            IsCurrent = isCurrent;
            IsOnline = isOnline;
            ApiRevisionDescription = apiRevisionDescription;
            ApiVersionDescription = apiVersionDescription;
            ApiVersionSetId = apiVersionSetId;
            IsSubscriptionRequired = isSubscriptionRequired;
            TermsOfServiceUri = termsOfServiceUri;
            Contact = contact;
            License = license;
            _rawData = rawData;
        }

        /// <summary> Description of the API. May include HTML formatting tags. </summary>
        public string Description { get; }
        /// <summary> Collection of authentication settings included into this API. </summary>
        public AuthenticationSettingsContract AuthenticationSettings { get; }
        /// <summary> Protocols over which API is made available. </summary>
        public SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get; }
        /// <summary> Type of API. </summary>
        public ApiType? ApiType { get; }
        /// <summary> Describes the revision of the API. If no value is provided, default revision 1 is created. </summary>
        public string ApiRevision { get; }
        /// <summary> Indicates the version identifier of the API if the API is versioned. </summary>
        public string ApiVersion { get; }
        /// <summary> Indicates if API revision is current api revision. </summary>
        public bool? IsCurrent { get; }
        /// <summary> Indicates if API revision is accessible via the gateway. </summary>
        public bool? IsOnline { get; }
        /// <summary> Description of the API Revision. </summary>
        public string ApiRevisionDescription { get; }
        /// <summary> Description of the API Version. </summary>
        public string ApiVersionDescription { get; }
        /// <summary> A resource identifier for the related ApiVersionSet. </summary>
        public ResourceIdentifier ApiVersionSetId { get; }
        /// <summary> Specifies whether an API or Product subscription is required for accessing the API. </summary>
        public bool? IsSubscriptionRequired { get; }
        /// <summary> A URL to the Terms of Service for the API. MUST be in the format of a URL. </summary>
        public Uri TermsOfServiceUri { get; }
        /// <summary> Contact information for the API. </summary>
        public ApiContactInformation Contact { get; }
        /// <summary> License information for the API. </summary>
        public ApiLicenseInformation License { get; }
    }
}
