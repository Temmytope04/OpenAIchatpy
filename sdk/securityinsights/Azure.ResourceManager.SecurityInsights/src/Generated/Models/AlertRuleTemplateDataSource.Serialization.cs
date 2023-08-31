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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AlertRuleTemplateDataSource : IUtf8JsonSerializable, IModelJsonSerializable<AlertRuleTemplateDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AlertRuleTemplateDataSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AlertRuleTemplateDataSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectorId))
            {
                writer.WritePropertyName("connectorId"u8);
                writer.WriteStringValue(ConnectorId);
            }
            if (Optional.IsCollectionDefined(DataTypes))
            {
                writer.WritePropertyName("dataTypes"u8);
                writer.WriteStartArray();
                foreach (var item in DataTypes)
                {
                    writer.WriteStringValue(item);
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

        internal static AlertRuleTemplateDataSource DeserializeAlertRuleTemplateDataSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> connectorId = default;
            Optional<IList<string>> dataTypes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectorId"u8))
                {
                    connectorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dataTypes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AlertRuleTemplateDataSource(connectorId.Value, Optional.ToList(dataTypes), rawData);
        }

        AlertRuleTemplateDataSource IModelJsonSerializable<AlertRuleTemplateDataSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertRuleTemplateDataSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AlertRuleTemplateDataSource>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AlertRuleTemplateDataSource IModelSerializable<AlertRuleTemplateDataSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAlertRuleTemplateDataSource(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AlertRuleTemplateDataSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AlertRuleTemplateDataSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAlertRuleTemplateDataSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
