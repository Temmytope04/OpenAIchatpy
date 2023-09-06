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
    [JsonConverter(typeof(TriggerRunConverter))]
    public partial class TriggerRun : IUtf8JsonSerializable, IModelJsonSerializable<TriggerRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TriggerRun>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TriggerRun>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerRun>(this, options.Format);

            writer.WriteStartObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TriggerRun DeserializeTriggerRun(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> triggerRunId = default;
            Optional<string> triggerName = default;
            Optional<string> triggerType = default;
            Optional<DateTimeOffset> triggerRunTimestamp = default;
            Optional<TriggerRunStatus> status = default;
            Optional<string> message = default;
            Optional<IReadOnlyDictionary<string, string>> properties = default;
            Optional<IReadOnlyDictionary<string, string>> triggeredPipelines = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("triggerRunId"u8))
                {
                    triggerRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerName"u8))
                {
                    triggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    triggerType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerRunTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerRunTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new TriggerRunStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("triggeredPipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    triggeredPipelines = dictionary;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TriggerRun(triggerRunId.Value, triggerName.Value, triggerType.Value, Optional.ToNullable(triggerRunTimestamp), Optional.ToNullable(status), message.Value, Optional.ToDictionary(properties), Optional.ToDictionary(triggeredPipelines), additionalProperties);
        }

        TriggerRun IModelJsonSerializable<TriggerRun>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerRun>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerRun(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TriggerRun>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerRun>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TriggerRun IModelSerializable<TriggerRun>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerRun>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTriggerRun(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TriggerRun"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TriggerRun"/> to convert. </param>
        public static implicit operator RequestContent(TriggerRun model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TriggerRun"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TriggerRun(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTriggerRun(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class TriggerRunConverter : JsonConverter<TriggerRun>
        {
            public override void Write(Utf8JsonWriter writer, TriggerRun model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TriggerRun Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerRun(document.RootElement);
            }
        }
    }
}
