// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class PublicCertificateData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(Blob))
            {
                writer.WritePropertyName("blob");
                writer.WriteBase64StringValue(Blob, "D");
            }
            if (Optional.IsDefined(PublicCertificateLocation))
            {
                writer.WritePropertyName("publicCertificateLocation");
                writer.WriteStringValue(PublicCertificateLocation.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PublicCertificateData DeserializePublicCertificateData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<byte[]> blob = default;
            Optional<PublicCertificateLocation> publicCertificateLocation = default;
            Optional<string> thumbprint = default;
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
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("blob"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            blob = property0.Value.GetBytesFromBase64("D");
                            continue;
                        }
                        if (property0.NameEquals("publicCertificateLocation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicCertificateLocation = property0.Value.GetString().ToPublicCertificateLocation();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PublicCertificateData(id, name, type, kind.Value, blob.Value, Optional.ToNullable(publicCertificateLocation), thumbprint.Value);
        }
    }
}
