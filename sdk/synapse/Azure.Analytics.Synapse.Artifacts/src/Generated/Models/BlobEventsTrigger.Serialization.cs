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
    [JsonConverter(typeof(BlobEventsTriggerConverter))]
    public partial class BlobEventsTrigger : IUtf8JsonSerializable, IModelJsonSerializable<BlobEventsTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BlobEventsTrigger>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BlobEventsTrigger>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BlobEventsTrigger>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Pipelines))
            {
                writer.WritePropertyName("pipelines"u8);
                writer.WriteStartArray();
                foreach (var item in Pipelines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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
            if (Optional.IsDefined(BlobPathBeginsWith))
            {
                writer.WritePropertyName("blobPathBeginsWith"u8);
                writer.WriteStringValue(BlobPathBeginsWith);
            }
            if (Optional.IsDefined(BlobPathEndsWith))
            {
                writer.WritePropertyName("blobPathEndsWith"u8);
                writer.WriteStringValue(BlobPathEndsWith);
            }
            if (Optional.IsDefined(IgnoreEmptyBlobs))
            {
                writer.WritePropertyName("ignoreEmptyBlobs"u8);
                writer.WriteBooleanValue(IgnoreEmptyBlobs.Value);
            }
            writer.WritePropertyName("events"u8);
            writer.WriteStartArray();
            foreach (var item in Events)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static BlobEventsTrigger DeserializeBlobEventsTrigger(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<TriggerPipelineReference>> pipelines = default;
            string type = default;
            Optional<string> description = default;
            Optional<TriggerRuntimeState> runtimeState = default;
            Optional<IList<object>> annotations = default;
            Optional<string> blobPathBeginsWith = default;
            Optional<string> blobPathEndsWith = default;
            Optional<bool> ignoreEmptyBlobs = default;
            IList<BlobEventType> events = default;
            string scope = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TriggerPipelineReference> array = new List<TriggerPipelineReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerPipelineReference.DeserializeTriggerPipelineReference(item));
                    }
                    pipelines = array;
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
                        if (property0.NameEquals("blobPathBeginsWith"u8))
                        {
                            blobPathBeginsWith = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blobPathEndsWith"u8))
                        {
                            blobPathEndsWith = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ignoreEmptyBlobs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreEmptyBlobs = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("events"u8))
                        {
                            List<BlobEventType> array = new List<BlobEventType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new BlobEventType(item.GetString()));
                            }
                            events = array;
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new BlobEventsTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, Optional.ToList(pipelines), blobPathBeginsWith.Value, blobPathEndsWith.Value, Optional.ToNullable(ignoreEmptyBlobs), events, scope);
        }

        BlobEventsTrigger IModelJsonSerializable<BlobEventsTrigger>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BlobEventsTrigger>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobEventsTrigger(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BlobEventsTrigger>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BlobEventsTrigger>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BlobEventsTrigger IModelSerializable<BlobEventsTrigger>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BlobEventsTrigger>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBlobEventsTrigger(doc.RootElement, options);
        }

        public static implicit operator RequestContent(BlobEventsTrigger model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BlobEventsTrigger(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBlobEventsTrigger(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class BlobEventsTriggerConverter : JsonConverter<BlobEventsTrigger>
        {
            public override void Write(Utf8JsonWriter writer, BlobEventsTrigger model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override BlobEventsTrigger Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeBlobEventsTrigger(document.RootElement);
            }
        }
    }
}
