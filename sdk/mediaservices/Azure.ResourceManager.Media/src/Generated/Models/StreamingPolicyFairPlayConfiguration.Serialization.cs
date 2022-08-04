// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class StreamingPolicyFairPlayConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomLicenseAcquisitionUriTemplate))
            {
                writer.WritePropertyName("customLicenseAcquisitionUrlTemplate");
                writer.WriteStringValue(CustomLicenseAcquisitionUriTemplate.AbsoluteUri);
            }
            writer.WritePropertyName("allowPersistentLicense");
            writer.WriteBooleanValue(AllowPersistentLicense);
            writer.WriteEndObject();
        }

        internal static StreamingPolicyFairPlayConfiguration DeserializeStreamingPolicyFairPlayConfiguration(JsonElement element)
        {
            Optional<Uri> customLicenseAcquisitionUriTemplate = default;
            bool allowPersistentLicense = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customLicenseAcquisitionUrlTemplate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customLicenseAcquisitionUriTemplate = null;
                        continue;
                    }
                    customLicenseAcquisitionUriTemplate = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowPersistentLicense"))
                {
                    allowPersistentLicense = property.Value.GetBoolean();
                    continue;
                }
            }
            return new StreamingPolicyFairPlayConfiguration(customLicenseAcquisitionUriTemplate.Value, allowPersistentLicense);
        }
    }
}
