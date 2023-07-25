// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class CheckPrivateLinkServiceVisibilityRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateLinkServiceAlias))
            {
                writer.WritePropertyName("privateLinkServiceAlias"u8);
                writer.WriteStringValue(PrivateLinkServiceAlias);
            }
            writer.WriteEndObject();
        }
    }
}
