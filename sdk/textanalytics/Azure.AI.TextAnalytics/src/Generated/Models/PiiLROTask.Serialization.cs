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
    internal partial class PiiLROTask : IUtf8JsonSerializable, IModelJsonSerializable<PiiLROTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PiiLROTask>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PiiLROTask>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PiiLROTask>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue(Parameters);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
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

        internal static PiiLROTask DeserializePiiLROTask(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PiiTaskParameters> parameters = default;
            AnalyzeTextLROTaskKind kind = default;
            Optional<string> taskName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = PiiTaskParameters.DeserializePiiTaskParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROTaskKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PiiLROTask(taskName.Value, kind, parameters.Value, rawData);
        }

        PiiLROTask IModelJsonSerializable<PiiLROTask>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PiiLROTask>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePiiLROTask(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PiiLROTask>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PiiLROTask>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PiiLROTask IModelSerializable<PiiLROTask>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PiiLROTask>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePiiLROTask(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PiiLROTask model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PiiLROTask(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePiiLROTask(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
