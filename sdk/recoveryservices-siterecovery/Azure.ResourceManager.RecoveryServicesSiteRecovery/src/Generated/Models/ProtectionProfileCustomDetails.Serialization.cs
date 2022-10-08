// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ProtectionProfileCustomDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WriteEndObject();
        }

        internal static ProtectionProfileCustomDetails DeserializeProtectionProfileCustomDetails(JsonElement element)
        {
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Existing": return ExistingProtectionProfile.DeserializeExistingProtectionProfile(element);
                    case "New": return NewProtectionProfile.DeserializeNewProtectionProfile(element);
                }
            }
            string resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownProtectionProfileCustomDetails(resourceType);
        }
    }
}
