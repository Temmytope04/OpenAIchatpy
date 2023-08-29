// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ChainingTriggerConverter))]
    public partial class ChainingTrigger : IUtf8JsonSerializable, IModelJsonSerializable<ChainingTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ChainingTrigger>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ChainingTrigger>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ChainingTrigger>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("pipeline"u8);
            writer.WriteObjectValue(Pipeline);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("dependsOn"u8);
            writer.WriteStartArray();
            foreach (var item in DependsOn)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("runDimension"u8);
            writer.WriteStringValue(RunDimension);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ChainingTrigger DeserializeChainingTrigger(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TriggerPipelineReference pipeline = default;
            string type = default;
            Optional<string> description = default;
            Optional<TriggerRuntimeState> runtimeState = default;
            Optional<IList<object>> annotations = default;
            IList<PipelineReference> dependsOn = default;
            string runDimension = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipeline"u8))
                {
                    pipeline = TriggerPipelineReference.DeserializeTriggerPipelineReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new TriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dependsOn"u8))
                        {
                            List<PipelineReference> array = new List<PipelineReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PipelineReference.DeserializePipelineReference(item));
                            }
                            dependsOn = array;
                            continue;
                        }
                        if (property0.NameEquals("runDimension"u8))
                        {
                            runDimension = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ChainingTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, pipeline, dependsOn, runDimension);
        }

        ChainingTrigger IModelJsonSerializable<ChainingTrigger>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ChainingTrigger>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeChainingTrigger(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ChainingTrigger>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ChainingTrigger>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ChainingTrigger IModelSerializable<ChainingTrigger>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ChainingTrigger>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeChainingTrigger(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ChainingTrigger model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ChainingTrigger(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeChainingTrigger(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class ChainingTriggerConverter : JsonConverter<ChainingTrigger>
        {
            public override void Write(Utf8JsonWriter writer, ChainingTrigger model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ChainingTrigger Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeChainingTrigger(document.RootElement);
            }
        }
    }
}
