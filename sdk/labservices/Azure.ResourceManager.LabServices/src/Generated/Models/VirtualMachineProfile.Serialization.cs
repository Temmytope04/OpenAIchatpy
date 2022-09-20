// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class VirtualMachineProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("createOption");
            writer.WriteStringValue(CreateOption.ToSerialString());
            writer.WritePropertyName("imageReference");
            writer.WriteObjectValue(ImageReference);
            writer.WritePropertyName("sku");
            writer.WriteObjectValue(Sku);
            if (Optional.IsDefined(AdditionalCapabilities))
            {
                writer.WritePropertyName("additionalCapabilities");
                writer.WriteObjectValue(AdditionalCapabilities);
            }
            writer.WritePropertyName("usageQuota");
            writer.WriteStringValue(UsageQuota, "P");
            if (Optional.IsDefined(UseSharedPassword))
            {
                writer.WritePropertyName("useSharedPassword");
                writer.WriteStringValue(UseSharedPassword.Value.ToSerialString());
            }
            writer.WritePropertyName("adminUser");
            writer.WriteObjectValue(AdminUser);
            if (Optional.IsDefined(NonAdminUser))
            {
                writer.WritePropertyName("nonAdminUser");
                writer.WriteObjectValue(NonAdminUser);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineProfile DeserializeVirtualMachineProfile(JsonElement element)
        {
            CreateOption createOption = default;
            LabVirtualMachineImageReference imageReference = default;
            Optional<OSType> osType = default;
            LabServicesSku sku = default;
            Optional<VirtualMachineAdditionalCapabilities> additionalCapabilities = default;
            TimeSpan usageQuota = default;
            Optional<EnableState> useSharedPassword = default;
            LabVirtualMachineCredential adminUser = default;
            Optional<LabVirtualMachineCredential> nonAdminUser = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createOption"))
                {
                    createOption = property.Value.GetString().ToCreateOption();
                    continue;
                }
                if (property.NameEquals("imageReference"))
                {
                    imageReference = LabVirtualMachineImageReference.DeserializeLabVirtualMachineImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osType = property.Value.GetString().ToOSType();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    sku = LabServicesSku.DeserializeLabServicesSku(property.Value);
                    continue;
                }
                if (property.NameEquals("additionalCapabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalCapabilities = VirtualMachineAdditionalCapabilities.DeserializeVirtualMachineAdditionalCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("usageQuota"))
                {
                    usageQuota = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("useSharedPassword"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useSharedPassword = property.Value.GetString().ToEnableState();
                    continue;
                }
                if (property.NameEquals("adminUser"))
                {
                    adminUser = LabVirtualMachineCredential.DeserializeLabVirtualMachineCredential(property.Value);
                    continue;
                }
                if (property.NameEquals("nonAdminUser"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nonAdminUser = LabVirtualMachineCredential.DeserializeLabVirtualMachineCredential(property.Value);
                    continue;
                }
            }
            return new VirtualMachineProfile(createOption, imageReference, Optional.ToNullable(osType), sku, additionalCapabilities.Value, usageQuota, Optional.ToNullable(useSharedPassword), adminUser, nonAdminUser.Value);
        }
    }
}
