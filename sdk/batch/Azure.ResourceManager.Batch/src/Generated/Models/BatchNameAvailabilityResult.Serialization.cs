// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchNameAvailabilityResult
    {
        internal static BatchNameAvailabilityResult DeserializeBatchNameAvailabilityResult(JsonElement element)
        {
            Optional<bool> nameAvailable = default;
            Optional<BatchNameUnavailableReason> reason = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reason = property.Value.GetString().ToBatchNameUnavailableReason();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new BatchNameAvailabilityResult(Optional.ToNullable(nameAvailable), Optional.ToNullable(reason), message.Value);
        }
    }
}
