// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class HeaderMatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Header))
            {
                writer.WritePropertyName("header"u8);
                writer.WriteStringValue(Header);
            }
            writer.WritePropertyName("match"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExactMatch))
            {
                writer.WritePropertyName("exactMatch"u8);
                writer.WriteStringValue(ExactMatch);
            }
            if (Optional.IsDefined(PrefixMatch))
            {
                writer.WritePropertyName("prefixMatch"u8);
                writer.WriteStringValue(PrefixMatch);
            }
            if (Optional.IsDefined(SuffixMatch))
            {
                writer.WritePropertyName("suffixMatch"u8);
                writer.WriteStringValue(SuffixMatch);
            }
            if (Optional.IsDefined(RegexMatch))
            {
                writer.WritePropertyName("regexMatch"u8);
                writer.WriteStringValue(RegexMatch);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HeaderMatch DeserializeHeaderMatch(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> header = default;
            Optional<string> exactMatch = default;
            Optional<string> prefixMatch = default;
            Optional<string> suffixMatch = default;
            Optional<string> regexMatch = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("header"u8))
                {
                    header = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("match"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("exactMatch"u8))
                        {
                            exactMatch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefixMatch"u8))
                        {
                            prefixMatch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("suffixMatch"u8))
                        {
                            suffixMatch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("regexMatch"u8))
                        {
                            regexMatch = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HeaderMatch(header.Value, exactMatch.Value, prefixMatch.Value, suffixMatch.Value, regexMatch.Value);
        }
    }
}
