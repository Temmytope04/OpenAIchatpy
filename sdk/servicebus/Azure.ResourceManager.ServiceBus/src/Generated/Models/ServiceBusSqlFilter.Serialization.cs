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

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusSqlFilter : IUtf8JsonSerializable, IModelJsonSerializable<ServiceBusSqlFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceBusSqlFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceBusSqlFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SqlExpression))
            {
                writer.WritePropertyName("sqlExpression"u8);
                writer.WriteStringValue(SqlExpression);
            }
            if (Optional.IsDefined(CompatibilityLevel))
            {
                writer.WritePropertyName("compatibilityLevel"u8);
                writer.WriteNumberValue(CompatibilityLevel.Value);
            }
            if (Optional.IsDefined(RequiresPreprocessing))
            {
                writer.WritePropertyName("requiresPreprocessing"u8);
                writer.WriteBooleanValue(RequiresPreprocessing.Value);
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

        internal static ServiceBusSqlFilter DeserializeServiceBusSqlFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sqlExpression = default;
            Optional<int> compatibilityLevel = default;
            Optional<bool> requiresPreprocessing = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlExpression"u8))
                {
                    sqlExpression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("compatibilityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compatibilityLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("requiresPreprocessing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requiresPreprocessing = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceBusSqlFilter(sqlExpression.Value, Optional.ToNullable(compatibilityLevel), Optional.ToNullable(requiresPreprocessing), rawData);
        }

        ServiceBusSqlFilter IModelJsonSerializable<ServiceBusSqlFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusSqlFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceBusSqlFilter>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceBusSqlFilter IModelSerializable<ServiceBusSqlFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceBusSqlFilter(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ServiceBusSqlFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ServiceBusSqlFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceBusSqlFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
