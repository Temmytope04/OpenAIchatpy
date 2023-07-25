// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsQueryTestingResult
    {
        internal static StreamAnalyticsQueryTestingResult DeserializeStreamAnalyticsQueryTestingResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StreamAnalyticsQueryTestingResultStatus> status = default;
            Optional<Uri> outputUri = default;
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<StreamAnalyticsErrorDetails>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new StreamAnalyticsQueryTestingResultStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("code"u8))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"u8))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamAnalyticsErrorDetails> array = new List<StreamAnalyticsErrorDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamAnalyticsErrorDetails.DeserializeStreamAnalyticsErrorDetails(item));
                            }
                            details = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StreamAnalyticsQueryTestingResult(code.Value, message.Value, target.Value, Optional.ToList(details), Optional.ToNullable(status), outputUri.Value);
        }
    }
}
