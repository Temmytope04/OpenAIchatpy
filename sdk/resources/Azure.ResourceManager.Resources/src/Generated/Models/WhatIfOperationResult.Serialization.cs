// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class WhatIfOperationResult
    {
        internal static WhatIfOperationResult DeserializeWhatIfOperationResult(JsonElement element)
        {
            Optional<string> status = default;
            Optional<ResponseError> error = default;
            Optional<IReadOnlyList<WhatIfChange>> changes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("changes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WhatIfChange> array = new List<WhatIfChange>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WhatIfChange.DeserializeWhatIfChange(item));
                            }
                            changes = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WhatIfOperationResult(status.Value, error.Value, Optional.ToList(changes));
        }
    }
}
