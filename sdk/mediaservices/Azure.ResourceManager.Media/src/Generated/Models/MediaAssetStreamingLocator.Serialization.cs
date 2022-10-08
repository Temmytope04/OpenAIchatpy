// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaAssetStreamingLocator
    {
        internal static MediaAssetStreamingLocator DeserializeMediaAssetStreamingLocator(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> assetName = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<Guid> streamingLocatorId = default;
            Optional<string> streamingPolicyName = default;
            Optional<string> defaultContentKeyPolicyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assetName"))
                {
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("streamingLocatorId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    streamingLocatorId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("streamingPolicyName"))
                {
                    streamingPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultContentKeyPolicyName"))
                {
                    defaultContentKeyPolicyName = property.Value.GetString();
                    continue;
                }
            }
            return new MediaAssetStreamingLocator(name.Value, assetName.Value, Optional.ToNullable(created), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(streamingLocatorId), streamingPolicyName.Value, defaultContentKeyPolicyName.Value);
        }
    }
}
