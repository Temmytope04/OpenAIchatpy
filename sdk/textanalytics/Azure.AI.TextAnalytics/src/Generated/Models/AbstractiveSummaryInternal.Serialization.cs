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

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AbstractiveSummaryInternal : IUtf8JsonSerializable, IModelJsonSerializable<AbstractiveSummaryInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AbstractiveSummaryInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AbstractiveSummaryInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AbstractiveSummaryInternal>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Optional.IsCollectionDefined(Contexts))
            {
                writer.WritePropertyName("contexts"u8);
                writer.WriteStartArray();
                foreach (var item in Contexts)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SummaryContextInternal>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static AbstractiveSummaryInternal DeserializeAbstractiveSummaryInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            Optional<IList<SummaryContextInternal>> contexts = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contexts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SummaryContextInternal> array = new List<SummaryContextInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SummaryContextInternal.DeserializeSummaryContextInternal(item));
                    }
                    contexts = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AbstractiveSummaryInternal(text, Optional.ToList(contexts), rawData);
        }

        AbstractiveSummaryInternal IModelJsonSerializable<AbstractiveSummaryInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AbstractiveSummaryInternal>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAbstractiveSummaryInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AbstractiveSummaryInternal>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AbstractiveSummaryInternal>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AbstractiveSummaryInternal IModelSerializable<AbstractiveSummaryInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AbstractiveSummaryInternal>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAbstractiveSummaryInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AbstractiveSummaryInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AbstractiveSummaryInternal"/> to convert. </param>
        public static implicit operator RequestContent(AbstractiveSummaryInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AbstractiveSummaryInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AbstractiveSummaryInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAbstractiveSummaryInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
