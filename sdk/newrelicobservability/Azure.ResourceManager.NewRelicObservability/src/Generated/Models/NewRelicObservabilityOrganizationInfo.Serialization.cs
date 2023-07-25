// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    internal partial class NewRelicObservabilityOrganizationInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OrganizationId))
            {
                writer.WritePropertyName("organizationId"u8);
                writer.WriteStringValue(OrganizationId);
            }
            writer.WriteEndObject();
        }

        internal static NewRelicObservabilityOrganizationInfo DeserializeNewRelicObservabilityOrganizationInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> organizationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizationId"u8))
                {
                    organizationId = property.Value.GetString();
                    continue;
                }
            }
            return new NewRelicObservabilityOrganizationInfo(organizationId.Value);
        }
    }
}
