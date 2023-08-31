// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The SourceControlSecurityTokenProperties. </summary>
    public partial class SourceControlSecurityTokenProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SourceControlSecurityTokenProperties"/>. </summary>
        public SourceControlSecurityTokenProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SourceControlSecurityTokenProperties"/>. </summary>
        /// <param name="accessToken"> The access token. </param>
        /// <param name="refreshToken"> The refresh token. </param>
        /// <param name="tokenType"> The token type. Must be either PersonalAccessToken or Oauth. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SourceControlSecurityTokenProperties(string accessToken, string refreshToken, SourceControlTokenType? tokenType, Dictionary<string, BinaryData> rawData)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            TokenType = tokenType;
            _rawData = rawData;
        }

        /// <summary> The access token. </summary>
        public string AccessToken { get; set; }
        /// <summary> The refresh token. </summary>
        public string RefreshToken { get; set; }
        /// <summary> The token type. Must be either PersonalAccessToken or Oauth. </summary>
        public SourceControlTokenType? TokenType { get; set; }
    }
}
