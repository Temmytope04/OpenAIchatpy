// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoStorage))
            {
                writer.WritePropertyName("autoStorage");
                writer.WriteObjectValue(AutoStorage);
            }
            if (Optional.IsDefined(PoolAllocationMode))
            {
                writer.WritePropertyName("poolAllocationMode");
                writer.WriteStringValue(PoolAllocationMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(KeyVaultReference))
            {
                writer.WritePropertyName("keyVaultReference");
                writer.WriteObjectValue(KeyVaultReference);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile");
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsCollectionDefined(AllowedAuthenticationModes))
            {
                if (AllowedAuthenticationModes != null)
                {
                    writer.WritePropertyName("allowedAuthenticationModes");
                    writer.WriteStartArray();
                    foreach (var item in AllowedAuthenticationModes)
                    {
                        writer.WriteStringValue(item.ToSerialString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedAuthenticationModes");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
