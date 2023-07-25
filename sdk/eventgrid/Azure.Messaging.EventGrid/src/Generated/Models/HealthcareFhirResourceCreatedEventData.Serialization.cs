// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(HealthcareFhirResourceCreatedEventDataConverter))]
    public partial class HealthcareFhirResourceCreatedEventData
    {
        internal static HealthcareFhirResourceCreatedEventData DeserializeHealthcareFhirResourceCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HealthcareFhirResourceType> resourceType = default;
            Optional<string> resourceFhirAccount = default;
            Optional<string> resourceFhirId = default;
            Optional<long> resourceVersionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new HealthcareFhirResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceFhirAccount"u8))
                {
                    resourceFhirAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceFhirId"u8))
                {
                    resourceFhirId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceVersionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceVersionId = property.Value.GetInt64();
                    continue;
                }
            }
            return new HealthcareFhirResourceCreatedEventData(Optional.ToNullable(resourceType), resourceFhirAccount.Value, resourceFhirId.Value, Optional.ToNullable(resourceVersionId));
        }

        internal partial class HealthcareFhirResourceCreatedEventDataConverter : JsonConverter<HealthcareFhirResourceCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, HealthcareFhirResourceCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override HealthcareFhirResourceCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHealthcareFhirResourceCreatedEventData(document.RootElement);
            }
        }
    }
}
