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
    public partial class TimeSeriesHierarchy : IUtf8JsonSerializable, IModelJsonSerializable<TimeSeriesHierarchy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TimeSeriesHierarchy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TimeSeriesHierarchy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesHierarchy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("source"u8);
            if (Source is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<TimeSeriesHierarchySource>)Source).Serialize(writer, options);
            }
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

        internal static TimeSeriesHierarchy DeserializeTimeSeriesHierarchy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            string name = default;
            TimeSeriesHierarchySource source = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = TimeSeriesHierarchySource.DeserializeTimeSeriesHierarchySource(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TimeSeriesHierarchy(id.Value, name, source, rawData);
        }

        TimeSeriesHierarchy IModelJsonSerializable<TimeSeriesHierarchy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesHierarchy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeSeriesHierarchy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TimeSeriesHierarchy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesHierarchy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TimeSeriesHierarchy IModelSerializable<TimeSeriesHierarchy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesHierarchy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTimeSeriesHierarchy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TimeSeriesHierarchy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TimeSeriesHierarchy"/> to convert. </param>
        public static implicit operator RequestContent(TimeSeriesHierarchy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TimeSeriesHierarchy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TimeSeriesHierarchy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTimeSeriesHierarchy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
