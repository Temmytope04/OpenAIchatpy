// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ThirdPartyProviderAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Authorizations))
            {
                writer.WritePropertyName("authorizations");
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagedByTenantId))
            {
                writer.WritePropertyName("managedByTenantId");
                writer.WriteStringValue(ManagedByTenantId);
            }
            writer.WriteEndObject();
        }

        internal static ThirdPartyProviderAuthorization DeserializeThirdPartyProviderAuthorization(JsonElement element)
        {
            Optional<IList<LightHouseAuthorization>> authorizations = default;
            Optional<string> managedByTenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LightHouseAuthorization> array = new List<LightHouseAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LightHouseAuthorization.DeserializeLightHouseAuthorization(item));
                    }
                    authorizations = array;
                    continue;
                }
                if (property.NameEquals("managedByTenantId"))
                {
                    managedByTenantId = property.Value.GetString();
                    continue;
                }
            }
            return new ThirdPartyProviderAuthorization(Optional.ToList(authorizations), managedByTenantId.Value);
        }
    }
}
