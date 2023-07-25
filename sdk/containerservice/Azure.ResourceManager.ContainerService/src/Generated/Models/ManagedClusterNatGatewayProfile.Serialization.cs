// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterNatGatewayProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedOutboundIPProfile))
            {
                writer.WritePropertyName("managedOutboundIPProfile"u8);
                writer.WriteObjectValue(ManagedOutboundIPProfile);
            }
            if (Optional.IsCollectionDefined(EffectiveOutboundIPs))
            {
                writer.WritePropertyName("effectiveOutboundIPs"u8);
                writer.WriteStartArray();
                foreach (var item in EffectiveOutboundIPs)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterNatGatewayProfile DeserializeManagedClusterNatGatewayProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedClusterManagedOutboundIPProfile> managedOutboundIPProfile = default;
            Optional<IList<WritableSubResource>> effectiveOutboundIPs = default;
            Optional<int> idleTimeoutInMinutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedOutboundIPProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedOutboundIPProfile = ManagedClusterManagedOutboundIPProfile.DeserializeManagedClusterManagedOutboundIPProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("effectiveOutboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    effectiveOutboundIPs = array;
                    continue;
                }
                if (property.NameEquals("idleTimeoutInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    idleTimeoutInMinutes = property.Value.GetInt32();
                    continue;
                }
            }
            return new ManagedClusterNatGatewayProfile(managedOutboundIPProfile.Value, Optional.ToList(effectiveOutboundIPs), Optional.ToNullable(idleTimeoutInMinutes));
        }
    }
}
