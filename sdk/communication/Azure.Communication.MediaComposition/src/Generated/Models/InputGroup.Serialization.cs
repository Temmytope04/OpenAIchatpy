// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class InputGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Position))
            {
                writer.WritePropertyName("position");
                writer.WriteObjectValue(Position);
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width");
                writer.WriteStringValue(Width);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height");
                writer.WriteStringValue(Height);
            }
            if (Optional.IsDefined(Layer))
            {
                writer.WritePropertyName("layer");
                writer.WriteStringValue(Layer);
            }
            writer.WriteEndObject();
        }

        internal static InputGroup DeserializeInputGroup(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "autoGridBased": return AutoGridInputGroup.DeserializeAutoGridInputGroup(element);
                    case "gridBased": return GridInputGroup.DeserializeGridInputGroup(element);
                }
            }
            InputGroupType kind = default;
            Optional<InputPosition> position = default;
            Optional<string> width = default;
            Optional<string> height = default;
            Optional<string> layer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new InputGroupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("position"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    position = InputPosition.DeserializeInputPosition(property.Value);
                    continue;
                }
                if (property.NameEquals("width"))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"))
                {
                    height = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("layer"))
                {
                    layer = property.Value.GetString();
                    continue;
                }
            }
            return new InputGroup(kind, position.Value, width.Value, height.Value, layer.Value);
        }
    }
}
