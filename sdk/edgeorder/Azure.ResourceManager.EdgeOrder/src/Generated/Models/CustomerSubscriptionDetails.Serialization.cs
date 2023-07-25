// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class CustomerSubscriptionDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RegisteredFeatures))
            {
                writer.WritePropertyName("registeredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RegisteredFeatures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LocationPlacementId))
            {
                writer.WritePropertyName("locationPlacementId"u8);
                writer.WriteStringValue(LocationPlacementId);
            }
            writer.WritePropertyName("quotaId"u8);
            writer.WriteStringValue(QuotaId);
            writer.WriteEndObject();
        }
    }
}
