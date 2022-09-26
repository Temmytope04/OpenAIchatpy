// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class NotificationEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NotificationDestination))
            {
                writer.WritePropertyName("notificationDestination");
                writer.WriteStringValue(NotificationDestination);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations");
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NotificationEndpoint DeserializeNotificationEndpoint(JsonElement element)
        {
            Optional<string> notificationDestination = default;
            Optional<IList<string>> locations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationDestination"))
                {
                    notificationDestination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"))
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
                    locations = array;
                    continue;
                }
            }
            return new NotificationEndpoint(notificationDestination.Value, Optional.ToList(locations));
        }
    }
}
