// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class CustomDnsSuffixConfigurationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DnsSuffix))
            {
                writer.WritePropertyName("dnsSuffix");
                writer.WriteStringValue(DnsSuffix);
            }
            if (Optional.IsDefined(CertificateUri))
            {
                writer.WritePropertyName("certificateUrl");
                writer.WriteStringValue(CertificateUri.AbsoluteUri);
            }
            if (Optional.IsDefined(KeyVaultReferenceIdentity))
            {
                writer.WritePropertyName("keyVaultReferenceIdentity");
                writer.WriteStringValue(KeyVaultReferenceIdentity);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CustomDnsSuffixConfigurationData DeserializeCustomDnsSuffixConfigurationData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<CustomDnsSuffixProvisioningState> provisioningState = default;
            Optional<string> provisioningDetails = default;
            Optional<string> dnsSuffix = default;
            Optional<Uri> certificateUrl = default;
            Optional<string> keyVaultReferenceIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToCustomDnsSuffixProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("provisioningDetails"))
                        {
                            provisioningDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsSuffix"))
                        {
                            dnsSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certificateUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                certificateUrl = null;
                                continue;
                            }
                            certificateUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("keyVaultReferenceIdentity"))
                        {
                            keyVaultReferenceIdentity = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CustomDnsSuffixConfigurationData(id, name, type, systemData, kind.Value, Optional.ToNullable(provisioningState), provisioningDetails.Value, dnsSuffix.Value, certificateUrl.Value, keyVaultReferenceIdentity.Value);
        }
    }
}
