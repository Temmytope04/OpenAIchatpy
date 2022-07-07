// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapInstallWithoutOSConfigSoftwareConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("bomUrl");
            writer.WriteStringValue(BomUri.AbsoluteUri);
            writer.WritePropertyName("sapBitsStorageAccountId");
            writer.WriteStringValue(SapBitsStorageAccountId);
            writer.WritePropertyName("softwareVersion");
            writer.WriteStringValue(SoftwareVersion);
            if (Optional.IsDefined(HighAvailabilitySoftwareConfiguration))
            {
                writer.WritePropertyName("highAvailabilitySoftwareConfiguration");
                writer.WriteObjectValue(HighAvailabilitySoftwareConfiguration);
            }
            writer.WritePropertyName("softwareInstallationType");
            writer.WriteStringValue(SoftwareInstallationType.ToString());
            writer.WriteEndObject();
        }

        internal static SapInstallWithoutOSConfigSoftwareConfiguration DeserializeSapInstallWithoutOSConfigSoftwareConfiguration(JsonElement element)
        {
            Uri bomUrl = default;
            string sapBitsStorageAccountId = default;
            string softwareVersion = default;
            Optional<HighAvailabilitySoftwareConfiguration> highAvailabilitySoftwareConfiguration = default;
            SapSoftwareInstallationType softwareInstallationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bomUrl"))
                {
                    bomUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapBitsStorageAccountId"))
                {
                    sapBitsStorageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softwareVersion"))
                {
                    softwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highAvailabilitySoftwareConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    highAvailabilitySoftwareConfiguration = Models.HighAvailabilitySoftwareConfiguration.DeserializeHighAvailabilitySoftwareConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("softwareInstallationType"))
                {
                    softwareInstallationType = new SapSoftwareInstallationType(property.Value.GetString());
                    continue;
                }
            }
            return new SapInstallWithoutOSConfigSoftwareConfiguration(softwareInstallationType, bomUrl, sapBitsStorageAccountId, softwareVersion, highAvailabilitySoftwareConfiguration.Value);
        }
    }
}
