// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> A site for the channel. </summary>
    public partial class BotChannelSite
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BotChannelSite"/>. </summary>
        /// <param name="siteName"> Site name. </param>
        /// <param name="isEnabled"> Whether this site is enabled for DirectLine channel. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public BotChannelSite(string siteName, bool isEnabled)
        {
            Argument.AssertNotNull(siteName, nameof(siteName));

            SiteName = siteName;
            IsEnabled = isEnabled;
            TrustedOrigins = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BotChannelSite"/>. </summary>
        /// <param name="tenantId"> Tenant Id. </param>
        /// <param name="siteId"> Site Id. </param>
        /// <param name="siteName"> Site name. </param>
        /// <param name="key"> Primary key. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="key2"> Secondary key. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="isEnabled"> Whether this site is enabled for DirectLine channel. </param>
        /// <param name="isTokenEnabled"> Whether this site is token enabled for channel. </param>
        /// <param name="isEndpointParametersEnabled"> Whether this site is EndpointParameters enabled for channel. </param>
        /// <param name="isDetailedLoggingEnabled"> Whether this site is disabled detailed logging for. </param>
        /// <param name="isBlockUserUploadEnabled"> Whether this site is enabled for block user upload. </param>
        /// <param name="isNoStorageEnabled"> Whether this no-storage site is disabled detailed logging for. </param>
        /// <param name="etag"> Entity Tag. </param>
        /// <param name="appId"> DirectLine application id. </param>
        /// <param name="isV1Enabled"> Whether this site is enabled for Bot Framework V1 protocol. </param>
        /// <param name="isV3Enabled"> Whether this site is enabled for Bot Framework V3 protocol. </param>
        /// <param name="isSecureSiteEnabled"> Whether this site is enabled for authentication with Bot Framework. </param>
        /// <param name="trustedOrigins"> List of Trusted Origin URLs for this site. This field is applicable only if isSecureSiteEnabled is True. </param>
        /// <param name="isWebChatSpeechEnabled"> Whether this site is enabled for Webchat Speech. </param>
        /// <param name="isWebchatPreviewEnabled"> Whether this site is enabled for preview versions of Webchat. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BotChannelSite(Guid? tenantId, string siteId, string siteName, string key, string key2, bool isEnabled, bool? isTokenEnabled, bool? isEndpointParametersEnabled, bool? isDetailedLoggingEnabled, bool? isBlockUserUploadEnabled, bool? isNoStorageEnabled, ETag? etag, string appId, bool? isV1Enabled, bool? isV3Enabled, bool? isSecureSiteEnabled, IList<string> trustedOrigins, bool? isWebChatSpeechEnabled, bool? isWebchatPreviewEnabled, Dictionary<string, BinaryData> rawData)
        {
            TenantId = tenantId;
            SiteId = siteId;
            SiteName = siteName;
            Key = key;
            Key2 = key2;
            IsEnabled = isEnabled;
            IsTokenEnabled = isTokenEnabled;
            IsEndpointParametersEnabled = isEndpointParametersEnabled;
            IsDetailedLoggingEnabled = isDetailedLoggingEnabled;
            IsBlockUserUploadEnabled = isBlockUserUploadEnabled;
            IsNoStorageEnabled = isNoStorageEnabled;
            ETag = etag;
            AppId = appId;
            IsV1Enabled = isV1Enabled;
            IsV3Enabled = isV3Enabled;
            IsSecureSiteEnabled = isSecureSiteEnabled;
            TrustedOrigins = trustedOrigins;
            IsWebChatSpeechEnabled = isWebChatSpeechEnabled;
            IsWebchatPreviewEnabled = isWebchatPreviewEnabled;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BotChannelSite"/> for deserialization. </summary>
        internal BotChannelSite()
        {
        }

        /// <summary> Tenant Id. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Site Id. </summary>
        public string SiteId { get; }
        /// <summary> Site name. </summary>
        public string SiteName { get; set; }
        /// <summary> Primary key. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string Key { get; }
        /// <summary> Secondary key. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string Key2 { get; }
        /// <summary> Whether this site is enabled for DirectLine channel. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> Whether this site is token enabled for channel. </summary>
        public bool? IsTokenEnabled { get; }
        /// <summary> Whether this site is EndpointParameters enabled for channel. </summary>
        public bool? IsEndpointParametersEnabled { get; set; }
        /// <summary> Whether this site is disabled detailed logging for. </summary>
        public bool? IsDetailedLoggingEnabled { get; set; }
        /// <summary> Whether this site is enabled for block user upload. </summary>
        public bool? IsBlockUserUploadEnabled { get; set; }
        /// <summary> Whether this no-storage site is disabled detailed logging for. </summary>
        public bool? IsNoStorageEnabled { get; set; }
        /// <summary> Entity Tag. </summary>
        public ETag? ETag { get; set; }
        /// <summary> DirectLine application id. </summary>
        public string AppId { get; set; }
        /// <summary> Whether this site is enabled for Bot Framework V1 protocol. </summary>
        public bool? IsV1Enabled { get; set; }
        /// <summary> Whether this site is enabled for Bot Framework V3 protocol. </summary>
        public bool? IsV3Enabled { get; set; }
        /// <summary> Whether this site is enabled for authentication with Bot Framework. </summary>
        public bool? IsSecureSiteEnabled { get; set; }
        /// <summary> List of Trusted Origin URLs for this site. This field is applicable only if isSecureSiteEnabled is True. </summary>
        public IList<string> TrustedOrigins { get; }
        /// <summary> Whether this site is enabled for Webchat Speech. </summary>
        public bool? IsWebChatSpeechEnabled { get; set; }
        /// <summary> Whether this site is enabled for preview versions of Webchat. </summary>
        public bool? IsWebchatPreviewEnabled { get; set; }
    }
}
