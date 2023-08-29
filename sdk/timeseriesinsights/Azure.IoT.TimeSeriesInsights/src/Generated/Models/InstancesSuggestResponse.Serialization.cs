// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class InstancesSuggestResponse : IUtf8JsonSerializable, IModelJsonSerializable<InstancesSuggestResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InstancesSuggestResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InstancesSuggestResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static InstancesSuggestResponse DeserializeInstancesSuggestResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<InstancesSearchStringSuggestion>> suggestions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("suggestions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstancesSearchStringSuggestion> array = new List<InstancesSearchStringSuggestion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstancesSearchStringSuggestion.DeserializeInstancesSearchStringSuggestion(item));
                    }
                    suggestions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InstancesSuggestResponse(Optional.ToList(suggestions), rawData);
        }

        InstancesSuggestResponse IModelJsonSerializable<InstancesSuggestResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancesSuggestResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InstancesSuggestResponse>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InstancesSuggestResponse IModelSerializable<InstancesSuggestResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInstancesSuggestResponse(doc.RootElement, options);
        }

        public static implicit operator RequestContent(InstancesSuggestResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator InstancesSuggestResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInstancesSuggestResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
