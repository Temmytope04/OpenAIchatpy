// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class DeviceCapabilities : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IotEdge))
            {
                writer.WritePropertyName("iotEdge");
                writer.WriteBooleanValue(IotEdge.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeviceCapabilities DeserializeDeviceCapabilities(JsonElement element)
        {
            Optional<bool> iotEdge = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("iotEdge"))
                {
                    iotEdge = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DeviceCapabilities(Optional.ToNullable(iotEdge));
        }
    }
}
