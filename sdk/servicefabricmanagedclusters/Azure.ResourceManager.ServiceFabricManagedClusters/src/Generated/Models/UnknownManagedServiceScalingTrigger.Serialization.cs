// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    internal partial class UnknownManagedServiceScalingTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownManagedServiceScalingTrigger DeserializeUnknownManagedServiceScalingTrigger(JsonElement element)
        {
            ServiceScalingTriggerKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new ServiceScalingTriggerKind(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownManagedServiceScalingTrigger(kind);
        }
    }
}
