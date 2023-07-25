// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class NotificationActionDetail
    {
        internal static NotificationActionDetail DeserializeNotificationActionDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mechanismType = default;
            Optional<string> name = default;
            Optional<string> status = default;
            Optional<string> subState = default;
            Optional<DateTimeOffset> sendTime = default;
            Optional<string> detail = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("MechanismType"u8))
                {
                    mechanismType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("SubState"u8))
                {
                    subState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("SendTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("Detail"u8))
                {
                    detail = property.Value.GetString();
                    continue;
                }
            }
            return new NotificationActionDetail(mechanismType.Value, name.Value, status.Value, subState.Value, Optional.ToNullable(sendTime), detail.Value);
        }
    }
}
