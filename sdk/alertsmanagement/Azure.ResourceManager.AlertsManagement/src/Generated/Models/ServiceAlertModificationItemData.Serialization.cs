// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertModificationItemData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ModificationEvent))
            {
                writer.WritePropertyName("modificationEvent");
                writer.WriteStringValue(ModificationEvent.Value.ToSerialString());
            }
            if (Optional.IsDefined(OldValue))
            {
                writer.WritePropertyName("oldValue");
                writer.WriteStringValue(OldValue);
            }
            if (Optional.IsDefined(NewValue))
            {
                writer.WritePropertyName("newValue");
                writer.WriteStringValue(NewValue);
            }
            if (Optional.IsDefined(ModifiedOn))
            {
                writer.WritePropertyName("modifiedAt");
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(ModifiedBy))
            {
                writer.WritePropertyName("modifiedBy");
                writer.WriteStringValue(ModifiedBy);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments");
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static ServiceAlertModificationItemData DeserializeServiceAlertModificationItemData(JsonElement element)
        {
            Optional<ServiceAlertModificationEvent> modificationEvent = default;
            Optional<string> oldValue = default;
            Optional<string> newValue = default;
            Optional<DateTimeOffset> modifiedAt = default;
            Optional<string> modifiedBy = default;
            Optional<string> comments = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modificationEvent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modificationEvent = property.Value.GetString().ToServiceAlertModificationEvent();
                    continue;
                }
                if (property.NameEquals("oldValue"))
                {
                    oldValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newValue"))
                {
                    newValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedBy"))
                {
                    modifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("comments"))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceAlertModificationItemData(Optional.ToNullable(modificationEvent), oldValue.Value, newValue.Value, Optional.ToNullable(modifiedAt), modifiedBy.Value, comments.Value, description.Value);
        }
    }
}
