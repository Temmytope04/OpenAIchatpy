// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The authorization properties for accessing the source code repository. </summary>
    public partial class SourceCodeRepoAuthInfoUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="SourceCodeRepoAuthInfoUpdateContent"/>. </summary>
        public SourceCodeRepoAuthInfoUpdateContent()
        {
        }

        /// <summary> The type of Auth token. </summary>
        public SourceCodeRepoAuthTokenType? TokenType { get; set; }
        /// <summary> The access token used to access the source control provider. </summary>
        public string Token { get; set; }
        /// <summary> The refresh token used to refresh the access token. </summary>
        public string RefreshToken { get; set; }
        /// <summary> The scope of the access token. </summary>
        public string Scope { get; set; }
        /// <summary> Time in seconds that the token remains valid. </summary>
        public int? ExpiresIn { get; set; }
    }
}
