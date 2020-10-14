// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class IncidentProperty
    {
        internal static IncidentProperty DeserializeIncidentProperty(JsonElement element)
        {
            AnomalySeverity maxSeverity = default;
            Optional<IncidentStatus> incidentStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSeverity"))
                {
                    maxSeverity = new AnomalySeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incidentStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    incidentStatus = new IncidentStatus(property.Value.GetString());
                    continue;
                }
            }
            return new IncidentProperty(maxSeverity, Optional.ToNullable(incidentStatus));
        }
    }
}
