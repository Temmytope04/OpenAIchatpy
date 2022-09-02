// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub AdmCredential. </summary>
    public partial class NotificationHubAdmCredential
    {
        /// <summary> Initializes a new instance of NotificationHubAdmCredential. </summary>
        public NotificationHubAdmCredential()
        {
        }

        /// <summary> Initializes a new instance of NotificationHubAdmCredential. </summary>
        /// <param name="clientId"> The client identifier. </param>
        /// <param name="clientSecret"> The credential secret access key. </param>
        /// <param name="authTokenUri"> The URL of the authorization token. </param>
        internal NotificationHubAdmCredential(string clientId, string clientSecret, Uri authTokenUri)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AuthTokenUri = authTokenUri;
        }

        /// <summary> The client identifier. </summary>
        public string ClientId { get; set; }
        /// <summary> The credential secret access key. </summary>
        public string ClientSecret { get; set; }
        /// <summary> The URL of the authorization token. </summary>
        public Uri AuthTokenUri { get; set; }
    }
}
