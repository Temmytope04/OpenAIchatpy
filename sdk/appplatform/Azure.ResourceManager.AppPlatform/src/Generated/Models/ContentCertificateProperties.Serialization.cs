// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ContentCertificateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content");
                writer.WriteStringValue(Content);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(CertificatePropertiesType);
            writer.WriteEndObject();
        }

        internal static ContentCertificateProperties DeserializeContentCertificateProperties(JsonElement element)
        {
            Optional<string> content = default;
            string type = default;
            Optional<string> thumbprint = default;
            Optional<string> issuer = default;
            Optional<string> issuedDate = default;
            Optional<string> expirationDate = default;
            Optional<string> activateDate = default;
            Optional<string> subjectName = default;
            Optional<IReadOnlyList<string>> dnsNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuedDate"))
                {
                    issuedDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDate"))
                {
                    expirationDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activateDate"))
                {
                    activateDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subjectName"))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsNames = array;
                    continue;
                }
            }
            return new ContentCertificateProperties(type, thumbprint.Value, issuer.Value, issuedDate.Value, expirationDate.Value, activateDate.Value, subjectName.Value, Optional.ToList(dnsNames), content.Value);
        }
    }
}
