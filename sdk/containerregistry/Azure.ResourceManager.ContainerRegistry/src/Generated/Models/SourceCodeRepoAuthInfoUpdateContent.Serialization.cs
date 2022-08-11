// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class SourceCodeRepoAuthInfoUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TokenType))
            {
                writer.WritePropertyName("tokenType");
                writer.WriteStringValue(TokenType.Value.ToString());
            }
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token");
                writer.WriteStringValue(Token);
            }
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken");
                writer.WriteStringValue(RefreshToken);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(ExpiresIn))
            {
                writer.WritePropertyName("expiresIn");
                writer.WriteNumberValue(ExpiresIn.Value);
            }
            writer.WriteEndObject();
        }
    }
}
