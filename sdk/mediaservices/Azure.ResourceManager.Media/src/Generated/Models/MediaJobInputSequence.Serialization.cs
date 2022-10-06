// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobInputSequence : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs");
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static MediaJobInputSequence DeserializeMediaJobInputSequence(JsonElement element)
        {
            Optional<IList<MediaJobInputClip>> inputs = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MediaJobInputClip> array = new List<MediaJobInputClip>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobInputClip.DeserializeMediaJobInputClip(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new MediaJobInputSequence(odataType, Optional.ToList(inputs));
        }
    }
}
