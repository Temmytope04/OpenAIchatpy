// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualApplianceNicProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(PublicIpAddress))
            {
                writer.WritePropertyName("publicIpAddress");
                writer.WriteStringValue(PublicIpAddress);
            }
            if (Optional.IsDefined(PrivateIpAddress))
            {
                writer.WritePropertyName("privateIpAddress");
                writer.WriteStringValue(PrivateIpAddress);
            }
            writer.WriteEndObject();
        }

        internal static VirtualApplianceNicProperties DeserializeVirtualApplianceNicProperties(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> publicIpAddress = default;
            Optional<string> privateIpAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicIpAddress"))
                {
                    publicIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"))
                {
                    privateIpAddress = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualApplianceNicProperties(name.Value, publicIpAddress.Value, privateIpAddress.Value);
        }
    }
}
