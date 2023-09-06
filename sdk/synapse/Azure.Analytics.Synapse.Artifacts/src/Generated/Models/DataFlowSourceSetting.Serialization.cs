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
    [JsonConverter(typeof(DataFlowSourceSettingConverter))]
    public partial class DataFlowSourceSetting : IUtf8JsonSerializable, IModelJsonSerializable<DataFlowSourceSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFlowSourceSetting>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFlowSourceSetting>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowSourceSetting>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceName))
            {
                writer.WritePropertyName("sourceName"u8);
                writer.WriteStringValue(SourceName);
            }
            if (Optional.IsDefined(RowLimit))
            {
                writer.WritePropertyName("rowLimit"u8);
                writer.WriteNumberValue(RowLimit.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowSourceSetting DeserializeDataFlowSourceSetting(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sourceName = default;
            Optional<int> rowLimit = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceName"u8))
                {
                    sourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rowLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowLimit = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowSourceSetting(sourceName.Value, Optional.ToNullable(rowLimit), additionalProperties);
        }

        DataFlowSourceSetting IModelJsonSerializable<DataFlowSourceSetting>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowSourceSetting>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlowSourceSetting(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFlowSourceSetting>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowSourceSetting>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFlowSourceSetting IModelSerializable<DataFlowSourceSetting>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowSourceSetting>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFlowSourceSetting(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataFlowSourceSetting"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataFlowSourceSetting"/> to convert. </param>
        public static implicit operator RequestContent(DataFlowSourceSetting model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataFlowSourceSetting"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataFlowSourceSetting(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFlowSourceSetting(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class DataFlowSourceSettingConverter : JsonConverter<DataFlowSourceSetting>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowSourceSetting model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowSourceSetting Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowSourceSetting(document.RootElement);
            }
        }
    }
}
