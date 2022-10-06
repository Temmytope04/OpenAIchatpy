// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class Remediation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Scripts))
            {
                writer.WritePropertyName("scripts");
                writer.WriteStartArray();
                foreach (var item in Scripts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Automated))
            {
                writer.WritePropertyName("automated");
                writer.WriteBooleanValue(Automated.Value);
            }
            if (Optional.IsDefined(PortalLink))
            {
                writer.WritePropertyName("portalLink");
                writer.WriteStringValue(PortalLink);
            }
            writer.WriteEndObject();
        }

        internal static Remediation DeserializeRemediation(JsonElement element)
        {
            Optional<string> description = default;
            Optional<IList<string>> scripts = default;
            Optional<bool> automated = default;
            Optional<string> portalLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scripts"))
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
                    scripts = array;
                    continue;
                }
                if (property.NameEquals("automated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    automated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("portalLink"))
                {
                    portalLink = property.Value.GetString();
                    continue;
                }
            }
            return new Remediation(description.Value, Optional.ToList(scripts), Optional.ToNullable(automated), portalLink.Value);
        }
    }
}
