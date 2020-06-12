// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ContainerServiceVMDiagnostics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            if (StorageUri != null)
            {
                writer.WritePropertyName("storageUri");
                writer.WriteStringValue(StorageUri);
            }
            writer.WriteEndObject();
        }

        internal static ContainerServiceVMDiagnostics DeserializeContainerServiceVMDiagnostics(JsonElement element)
        {
            bool enabled = default;
            string storageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageUri = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceVMDiagnostics(enabled, storageUri);
        }
    }
}
