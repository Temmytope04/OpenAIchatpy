// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VmSizeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VCpusAvailable))
            {
                writer.WritePropertyName("vCPUsAvailable");
                writer.WriteNumberValue(VCpusAvailable.Value);
            }
            if (Optional.IsDefined(VCpusPerCore))
            {
                writer.WritePropertyName("vCPUsPerCore");
                writer.WriteNumberValue(VCpusPerCore.Value);
            }
            writer.WriteEndObject();
        }

        internal static VmSizeProperties DeserializeVmSizeProperties(JsonElement element)
        {
            Optional<int> vcpUsAvailable = default;
            Optional<int> vcpUsPerCore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCPUsAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vcpUsAvailable = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vCPUsPerCore"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vcpUsPerCore = property.Value.GetInt32();
                    continue;
                }
            }
            return new VmSizeProperties(Optional.ToNullable(vcpUsAvailable), Optional.ToNullable(vcpUsPerCore));
        }
    }
}
