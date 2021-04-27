// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LibraryResourceInfoConverter))]
    public partial class LibraryResourceInfo
    {
        internal static LibraryResourceInfo DeserializeLibraryResourceInfo(JsonElement element)
        {
            Optional<string> id = default;
            Optional<int> recordId = default;
            Optional<string> state = default;
            Optional<string> created = default;
            Optional<string> changed = default;
            Optional<string> type = default;
            Optional<string> name = default;
            Optional<string> operationId = default;
            Optional<string> artifactId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recordId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recordId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"))
                {
                    created = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changed"))
                {
                    changed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactId"))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
            }
            return new LibraryResourceInfo(id.Value, Optional.ToNullable(recordId), state.Value, created.Value, changed.Value, type.Value, name.Value, operationId.Value, artifactId.Value);
        }

        internal partial class LibraryResourceInfoConverter : JsonConverter<LibraryResourceInfo>
        {
            public override void Write(Utf8JsonWriter writer, LibraryResourceInfo model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override LibraryResourceInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryResourceInfo(document.RootElement);
            }
        }
    }
}
