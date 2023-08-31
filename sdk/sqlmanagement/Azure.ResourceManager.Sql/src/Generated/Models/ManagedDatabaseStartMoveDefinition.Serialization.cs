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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedDatabaseStartMoveDefinition : IUtf8JsonSerializable, IModelJsonSerializable<ManagedDatabaseStartMoveDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedDatabaseStartMoveDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedDatabaseStartMoveDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("destinationManagedDatabaseId"u8);
            writer.WriteStringValue(DestinationManagedDatabaseId);
            if (Optional.IsDefined(OperationMode))
            {
                writer.WritePropertyName("operationMode"u8);
                writer.WriteStringValue(OperationMode.Value.ToString());
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

        internal static ManagedDatabaseStartMoveDefinition DeserializeManagedDatabaseStartMoveDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier destinationManagedDatabaseId = default;
            Optional<ManagedDatabaseMoveOperationMode> operationMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destinationManagedDatabaseId"u8))
                {
                    destinationManagedDatabaseId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationMode = new ManagedDatabaseMoveOperationMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedDatabaseStartMoveDefinition(destinationManagedDatabaseId, Optional.ToNullable(operationMode), rawData);
        }

        ManagedDatabaseStartMoveDefinition IModelJsonSerializable<ManagedDatabaseStartMoveDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedDatabaseStartMoveDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedDatabaseStartMoveDefinition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedDatabaseStartMoveDefinition IModelSerializable<ManagedDatabaseStartMoveDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedDatabaseStartMoveDefinition(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ManagedDatabaseStartMoveDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ManagedDatabaseStartMoveDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedDatabaseStartMoveDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
