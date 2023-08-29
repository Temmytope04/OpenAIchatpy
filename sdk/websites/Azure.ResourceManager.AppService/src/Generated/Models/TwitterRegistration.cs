// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the app registration for the Twitter provider. </summary>
    public partial class TwitterRegistration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TwitterRegistration"/>. </summary>
        public TwitterRegistration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TwitterRegistration"/>. </summary>
        /// <param name="consumerKey">
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </param>
        /// <param name="consumerSecretSettingName">
        /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        /// application used for sign-in.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TwitterRegistration(string consumerKey, string consumerSecretSettingName, Dictionary<string, BinaryData> rawData)
        {
            ConsumerKey = consumerKey;
            ConsumerSecretSettingName = consumerSecretSettingName;
            _rawData = rawData;
        }

        /// <summary>
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        public string ConsumerKey { get; set; }
        /// <summary>
        /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        /// application used for sign-in.
        /// </summary>
        public string ConsumerSecretSettingName { get; set; }
    }
}
