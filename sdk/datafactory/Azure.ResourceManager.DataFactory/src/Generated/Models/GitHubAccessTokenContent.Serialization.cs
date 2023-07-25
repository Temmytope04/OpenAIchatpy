// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class GitHubAccessTokenContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("gitHubAccessCode"u8);
            writer.WriteStringValue(GitHubAccessCode);
            if (Optional.IsDefined(GitHubClientId))
            {
                writer.WritePropertyName("gitHubClientId"u8);
                writer.WriteStringValue(GitHubClientId);
            }
            if (Optional.IsDefined(GitHubClientSecret))
            {
                writer.WritePropertyName("gitHubClientSecret"u8);
                writer.WriteObjectValue(GitHubClientSecret);
            }
            writer.WritePropertyName("gitHubAccessTokenBaseUrl"u8);
            writer.WriteStringValue(GitHubAccessTokenBaseUri.AbsoluteUri);
            writer.WriteEndObject();
        }
    }
}
