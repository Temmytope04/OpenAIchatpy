// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    public partial class ChangePointDetectResponse
    {
        internal static ChangePointDetectResponse DeserializeChangePointDetectResponse(JsonElement element)
        {
            Optional<int> period = default;
            Optional<IReadOnlyList<bool>> isChangePoint = default;
            Optional<IReadOnlyList<float>> confidenceScores = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("period"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isChangePoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<bool> array = new List<bool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBoolean());
                    }
                    isChangePoint = array;
                    continue;
                }
                if (property.NameEquals("confidenceScores"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    confidenceScores = array;
                    continue;
                }
            }
            return new ChangePointDetectResponse(Optional.ToNullable(period), Optional.ToList(isChangePoint), Optional.ToList(confidenceScores));
        }
    }
}
